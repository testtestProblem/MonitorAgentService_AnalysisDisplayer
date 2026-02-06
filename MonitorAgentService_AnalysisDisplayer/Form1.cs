using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorAgentService_AnalysisDisplayer
{
    public partial class Form1 : Form
    {
        private string selectedFilePath = "", selectedFilePath_scanBadSsd = "";
        private LogData logData;
        private string logDataTempS = "";

        private string systemInfo = "", cpuInfo = "", batteryInfo = "", ssdInfo = "", fanInfo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_openManual_Click(object sender, EventArgs e)
        {
            // 1. Create the dialog object
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 2. Set the title and default folder
                openFileDialog.Title = "Select a Log File";
                openFileDialog.InitialDirectory = @"C:\ProgramData\UserData\logs\WinMate\";

                // 3. Set the Filter (CRITICAL STEP)
                // Format: "Display Name|*.extension|Display Name 2|*.ext2"
                openFileDialog.Filter = "JSON Log Files (*.json)|*.json|All Files (*.*)|*.*";

                // 4. Show the dialog and check if the user clicked "OK"
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 5. Get the selected file path
                    selectedFilePath = openFileDialog.FileName;

                    // 6. Pass this path to your processing function
                    logData = LoadAndFillLogData(selectedFilePath);
                }

                if (logData != null)
                {
                    DumpLogDataToString(logData);
                }
            }
        }

        private void btn_scanBadFile_Click(object sender, EventArgs e)
        {
            //get path
            // 1. Create the dialog object
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // 2. Configure settings
                folderDialog.Description = "Select the Log Directory";
                folderDialog.ShowNewFolderButton = false; // Usually false for a "Read-Only" tool

                // Optional: Set a starting path
                folderDialog.SelectedPath = @"C:\ProgramData\UserData\logs\WinMate\";

                // 3. Show dialog and check result
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // 4. Get the selected folder path
                    string selectedFilePath_scanBadSsd = folderDialog.SelectedPath;

                    // 1. Run the scan
                    List<string> badSsdLogs = FindBadSsdLogs(selectedFilePath_scanBadSsd);

                    // 2. Show Results
                    if (badSsdLogs.Count > 0)
                    {
                        string message = "Found issues in these files:\n" + string.Join("\n", badSsdLogs);
                        MessageBox.Show(message, "SSD Health Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblSSDBadFile.Text = string.Join("\n", badSsdLogs);
                    }
                    else
                    {
                        MessageBox.Show("Scan Complete: All SSD logs are Green!", "Health OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
            }

            
        }

        public LogData LoadAndFillLogData(string filePath)
        {
            // Step 1: Read the raw JSON text from the file
            // Example content: "{ 'current_date_time': '2025-11-26...', 'CPU': ... }"
            string jsonContent = File.ReadAllText(filePath);

            // Step 2: Deserialize (The "Fill In" Step)
            // This converts the string into a real C# 'LogData' object
            LogData filledData = JsonConvert.DeserializeObject<LogData>(jsonContent);

            // Step 3: (Optional) Manually fill in data that isn't in the JSON file
            // For example, the filename itself is often useful to keep
            if (filledData != null)
            {
                filledData.SourceFileName = Path.GetFileName(filePath);
            }

            return filledData;
        }

        private void DumpLogDataToString(LogData log)
        {
            if (log == null) return;

            // --- 1. System & Version Info ---
            systemInfo = $"Time: {logData.CurrentDateTime}\n" +
                                $"File: {logData.SourceFileName}\n" +
                                $"Service Ver: {logData.Version?.ServiceVersion ?? "N/A"}\n" +
                                $"Config Ver:  {logData.Version?.ConfigVersion ?? "N/A"}\n" +
                                $"BIOS Serial: {logData.Bios?.SerialNumber ?? "N/A"}\n" +
                                $"RAM Serial:  {logData.RAM?.SerialNumber ?? "N/A"}";

            // --- 2. CPU Info ---
            cpuInfo = "No CPU Data";
            if (logData.CPU != null)
            {
                cpuInfo = $"Temp:  {logData.CPU.Temperature}°C\n" +
                          $"Usage: {logData.CPU.Usage}%\n" +
                          $"Alerts: {logData.CPU.TemperatureCount}";
            }

            // --- 3. Battery Info ---
            batteryInfo = "No Battery Data";
            if (logData.Battery != null)
            {
                batteryInfo = $"Health: {logData.Battery.HealthStatus}\n" +
                              $"Temp:   {logData.Battery.Temperature}°C\n" +
                              $"Charge: {logData.Battery.FullChargeCapacity} / {logData.Battery.DesignCapacity}\n" +
                              $"Cycles: {logData.Battery.CycleCount}\n" +
                              $"Voltage: {logData.Battery.Voltage} mV\n" +
                              $"Mfg:     {logData.Battery.Manufacturer}";
            }

            // --- 4. SSD Info ---
            ssdInfo = "No SSD Data";
            if (logData.SSD != null)
            {
                ssdInfo = $"Model:  {logData.SSD.Vendor}\n" +
                          $"Health: {logData.SSD.HealthStatus}\n" +
                          $"Temp:   {logData.SSD.Temperature}°C\n" +
                          $"Writes: {logData.SSD.TotalHostWrite} GB\n" +
                          $"Hours:  {logData.SSD.PowerOnHours}";
            }

            // --- 5. Fan Info ---
            fanInfo = "No Fan Data";
            if (logData.Fan != null)
            {
                fanInfo = $"Current: {logData.Fan.CurrentSpeed} RPM\n" +
                          $"Avg:     {logData.Fan.SpeedAverage} RPM\n" +
                          $"Max:     {logData.Fan.SpeedMax} RPM";
            }

            // --- 6. Assign to your Labels ---
            // Assuming you have created these labels in your Form Designer
            lblSystem.Text = systemInfo;
            lblCPU.Text = cpuInfo;
            lblBattery.Text = batteryInfo;
            lblSSD.Text = ssdInfo;
            lblFan.Text = fanInfo; 
        }

        public List<string> FindBadSsdLogs(string folderPath)
        {
            var badFiles = new List<string>();

            // 1. Get all JSON files in the folder
            if (!Directory.Exists(folderPath)) return badFiles;
            string[] files = Directory.GetFiles(folderPath, "*.json");

            foreach (string file in files)
            {
                try
                {
                    // 2. Read file content
                    string content = File.ReadAllText(file);

                    // 3. Deserialize only what we need (Dynamic is faster for simple checks)
                    // Or use your existing LogData class if you prefer strict typing.
                    dynamic log = JsonConvert.DeserializeObject(content);

                    // 4. Check the Condition: Is SSD Health NOT "green"?
                    // We use ?. to prevent crashing if "SSD" or "health_status" is missing.
                    string health = (string)log?.SSD?.health_status;

                    if (health == null || health.ToLower() != "green")
                    {
                        // It's a match! Add filename to list.
                        badFiles.Add(Path.GetFileName(file));
                    }
                }
                catch (Exception ex)
                {
                    // Just skip corrupted files
                    Console.WriteLine($"Skipping {file}: {ex.Message}");
                }
            }

            return badFiles;
        }
         

        // Example helper function to handle the data after selection
        private void LoadAndDisplayData(string path)
        {
            // Use the parser we created in the previous step
            /*LogData data = ParseLogFile(path); // Assumes you have the ParseLogFile method from before
            if (data != null)
            {
                MessageBox.Show($"Successfully loaded log from: {data.CurrentDateTime}");
            }*/
        }
    }
}
