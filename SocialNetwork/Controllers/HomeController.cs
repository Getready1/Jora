using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialNetwork.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public byte[] Index()
        {
            string pathSource = @"C:\Users\mike\Documents\GitHub\Jora\static\index.html";
            byte[] mainPage;

            try
            {

                using (FileStream fsSource = new FileStream(pathSource,
                    FileMode.Open, FileAccess.Read))
                {
                    mainPage = new byte[fsSource.Length];
                    int numBytesToRead = (int)fsSource.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        int n = fsSource.Read(mainPage, numBytesRead, numBytesToRead);

                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = mainPage.Length;
                }

                return mainPage;
            }
            catch
            {
                return null;
            }
        }
    }
}
