using System.Net.Http;
using System.Threading.Tasks;

namespace Kudu.Contracts.Jobs
{
    public interface IContinuousJobsManager : IJobsManager<ContinuousJob>
    {
        void DisableJob(string jobName);

        void EnableJob(string jobName);

        Task<HttpResponseMessage> RequestPassthrough(string jobName, HttpRequestMessage request);
    }
}