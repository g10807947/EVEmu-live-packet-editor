namespace Marshal
{
    class Win32Exception : System.ComponentModel.Win32Exception
    {
        private string detail;

        public override string Message
        {
            get
            {
                return detail + @" (" + NativeErrorCode + @"): " + base.Message;
            }
        }

        public Win32Exception(string detail) : base()
        {
            this.detail = detail;
        }
    }
}
