namespace CadastroClientes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ConfigConexao configConexao = new ConfigConexao();
            //configConexao.ShowDialog();

            try
            {
                ApplicationConfiguration.Initialize();
                Login formlogin = new Login();
                formlogin.ShowDialog();

                if (formlogin.FMP == true)
                {
                    Application.Run(new Menu());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}