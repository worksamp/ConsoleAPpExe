using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RecruxPortableClassLibrary.Managers;
using Microsoft.WindowsAzure.MobileServices;
using System.Net.Http;

namespace HiresmartBuild.ConsoleApp
{
    class Program
    {
        public static MobileServiceClient MobileServiceClient;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Team");
            
            var data = SaveBuildTest();
            if (data == true)
            {
                Console.WriteLine("successfully called mobile service");
            }
            else
            {
                Console.WriteLine("Return false");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static bool SaveBuildTest()
        {
            try
            {
                MobileServiceClient = new MobileServiceClient("http://recruxmobileservicenetbackend.azure-mobile.net/", "wFJNdBVGmNtgeDODnfIsEHysuHLDLv89");
                var data = MobileServiceClient.InvokeApiAsync<bool>("SaveBuildTest", HttpMethod.Get, null).Result;
                //var data = RecruxPortableClassLibrary.Managers.CandidateManager.Instance.SaveBuildTest().Result;
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
