﻿namespace EFCorePractice.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public TimeSpan Duration { get; set; }
        public int ReleaseYear { get; set; }
        public int? AgeRestriction { get; set; }
        public string Description { get; set; }
        public ICollection<Session> Sessions { get; set; } // Navigation property
    }
}