

using EFAnotatedPOC.Domain;
using EFAnotatedPOC.Repository;

namespace EFAnotatedPOC.Service
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
