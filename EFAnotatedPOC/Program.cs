using System;
using EFAnotatedPOC.Context;
using EFAnotatedPOC.Domain;
using EFAnotatedPOC.Service;


namespace EFAnotatedPOC
{
    public class Program
    {
        private static readonly CurrentStateCallInfoService currentStateCallInfoService = new CurrentStateCallInfoService();

        public static void Main(string[] args)
        {
            try
            {
                CurrentStateCallInfo currentStateCallInfo = new CurrentStateCallInfo("1", "1" ,"");
                currentStateCallInfoService.Save(currentStateCallInfo);

                CurrentStateCallInfo currentStateCallInfo2 = new CurrentStateCallInfo("1", "1" ,"");
                currentStateCallInfoService.Save(currentStateCallInfo);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
