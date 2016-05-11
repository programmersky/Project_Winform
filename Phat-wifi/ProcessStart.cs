namespace Phát_Wifi_Hẹn_giờ_tắt_máy
{
    internal class ProcessStart
    {
        private string v1;
        private string v2;

        public ProcessStart(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public bool CreateNoWindow { get; internal set; }
        public bool RedirectStandardOutput { get; internal set; }
        public bool UseShellExecute { get; internal set; }
    }
}