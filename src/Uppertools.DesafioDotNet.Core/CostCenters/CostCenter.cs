using Abp.Domain.Entities;

namespace Uppertools.DesafioDotNet.CostCenters
{
    public class CostCenter : Entity
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
