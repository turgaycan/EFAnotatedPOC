using Domain.Domain;
using EFDAL.Repository;

namespace EFService.Service
{
    public class CurrentStateCallInfoService
    {
        private CurrentStateCallInfoRepository currentStateCallInfoRepository;

        public CurrentStateCallInfoService()
        {
            currentStateCallInfoRepository = new CurrentStateCallInfoRepository();
        }

        public void Save(CurrentStateCallInfo currentStateCallInfo)
        {
            currentStateCallInfoRepository.Add(currentStateCallInfo);
        }

    }
}
