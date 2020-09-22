using System;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class Precinct
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Models.Address Addresses { get; set; }
    }
}
