using System;

namespace Voting.Data.Models.ModelsCodeFirst
{

    [Serializable]
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public int CountyId { get; set; }
        public int? AddressId { get; set; }

        public virtual Models.Address Address { get; set; }
        public virtual County County { get; set; }
        public virtual State State { get; set; }
    }
}
