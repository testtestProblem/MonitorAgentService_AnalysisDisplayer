using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MonitorAgentService_AnalysisDisplayer
{
    public class LogData
    {
        // Metadata: Not in JSON, but useful for your App to track file names
        [Newtonsoft.Json.JsonIgnore]
        public string SourceFileName { get; set; }

        [JsonProperty("current_date_time")]
        public DateTime CurrentDateTime { get; set; }

        [JsonProperty("Version")]
        public VersionInfo Version { get; set; }

        [JsonProperty("Bios_Serial_Number")]
        public BiosInfo Bios { get; set; }

        [JsonProperty("CPU")]
        public CpuInfo CPU { get; set; }

        [JsonProperty("Battery")]
        public BatteryInfo Battery { get; set; }

        [JsonProperty("SSD")]
        public SsdInfo SSD { get; set; }

        [JsonProperty("MB_RAM")]
        public RamInfo RAM { get; set; }

        [JsonProperty("Fan")]
        public FanInfo Fan { get; set; }

        [JsonProperty("Wifi_card_1")]
        public WifiInfo Wifi1 { get; set; }

        [JsonProperty("Wifi_card_2")]
        public WifiInfo Wifi2 { get; set; }
    }

    public class VersionInfo
    {
        [JsonProperty("MonitorAgentService_STD")]
        public string ServiceVersion { get; set; }

        [JsonProperty("Configfile")]
        public string ConfigVersion { get; set; }
    }

    public class BiosInfo
    {
        [JsonProperty("Bios_serial_number")]
        public string SerialNumber { get; set; }
    }

    public class CpuInfo
    {
        [JsonProperty("temperature")]
        public int Temperature { get; set; }

        [JsonProperty("temperature_count")]
        public int TemperatureCount { get; set; }

        [JsonProperty("usage")]
        public int Usage { get; set; }
    }

    public class BatteryInfo
    {
        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("temperature")]
        public int Temperature { get; set; }

        [JsonProperty("design_capacity")]
        public int DesignCapacity { get; set; }

        [JsonProperty("full_charge_capacity")]
        public int FullChargeCapacity { get; set; }

        [JsonProperty("cycle_count")]
        public int CycleCount { get; set; }

        [JsonProperty("value_loading_voltage")]
        public int Voltage { get; set; }

        [JsonProperty("health_status")]
        public string HealthStatus { get; set; }
    }

    public class SsdInfo
    {
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("temperature")]
        public int Temperature { get; set; }

        [JsonProperty("temperature_count")]
        public int TemperatureCount { get; set; }

        [JsonProperty("health_status")]
        public string HealthStatus { get; set; }

        [JsonProperty("total_host_read")]
        public long TotalHostRead { get; set; }

        [JsonProperty("total_host_write")]
        public long TotalHostWrite { get; set; }

        [JsonProperty("power_on_hours")]
        public int PowerOnHours { get; set; }

        [JsonProperty("unsafe_shutdowns")]
        public int UnsafeShutdowns { get; set; }

        [JsonProperty("media_and_data_integrity_errors")]
        public int MediaErrors { get; set; }
    }

    public class RamInfo
    {
        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }
    }

    public class FanInfo
    {
        [JsonProperty("current_speed")]
        public int CurrentSpeed { get; set; }

        [JsonProperty("speed_max")]
        public int SpeedMax { get; set; }

        [JsonProperty("speed_min")]
        public int SpeedMin { get; set; }

        [JsonProperty("speed_average")]
        public int SpeedAverage { get; set; }

        [JsonProperty("speed_overthreshold")]
        public int OverThresholdCount { get; set; }
    }

    public class WifiInfo
    {
        [JsonProperty("type_name")]
        public string TypeName { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("driver_version")]
        public string DriverVersion { get; set; }
    }


}
