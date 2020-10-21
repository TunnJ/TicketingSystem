using System;
namespace ToDoList.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all-all";
            string[] filters = FilterString.Split('-');
            Name = filters[0];
            StatusId = filters[1];
            SprintNumber = filters[2];
            PointValue = filters[3];
        }
        public string FilterString { get; }
        public string Name { get; }
        public string StatusId { get; }
        public string SprintNumber { get; }
        public string PointValue { get; }

        public bool HasName => Name.ToLower() != "all";
        public bool HasStatus => StatusId.ToLower() != "all";
        public bool HasSprintNumber => SprintNumber != "all";
        public bool HasPointValue => PointValue.ToLower() != "all";
    }
}
