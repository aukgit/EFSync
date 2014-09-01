﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Project.Models.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TestDbEntities : DbContext
    {
        public TestDbEntities()
            : base("name=TestDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<SamepleTable> SamepleTables { get; set; }
        public virtual DbSet<NewRelDb> NewRelDbs { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Favourite> Favourites { get; set; }
        public virtual DbSet<LearningPile> LearningPiles { get; set; }
        public virtual DbSet<MakeMcqQuestion> MakeMcqQuestions { get; set; }
        public virtual DbSet<MCQ> MCQs { get; set; }
        public virtual DbSet<MCQTAKEN> MCQTAKENs { get; set; }
        public virtual DbSet<Mistake> Mistakes { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationSeen> NotificationSeens { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SuggestedVideo> SuggestedVideos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WishList> WishLists { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}
