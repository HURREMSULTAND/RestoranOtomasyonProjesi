using RestoranOtomasyonProjesi.Forms;
using RestoranOtomasyonProjesi.Forms.CustomerForms;
using RestoranOtomasyonProjesi.Forms.ManagerForms;
using RestoranOtomasyonProjesi.LoginForms;


namespace RestoranOtomasyonProjesi
{
    internal static class Program
    {
        public static string SiparisSuresi { get; internal set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FirstLoginForms());
        }
    }
}
