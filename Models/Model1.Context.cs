﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaoMoi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BaoMoiEntities1 : DbContext
    {
        public BaoMoiEntities1()
            : base("name=BaoMoiEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<bannerContact> bannerContacts { get; set; }
        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<cate> cates { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<category1> category1 { get; set; }
        public virtual DbSet<category2> category2 { get; set; }
        public virtual DbSet<category5> category5 { get; set; }
        public virtual DbSet<category6> category6 { get; set; }
        public virtual DbSet<footer> footers { get; set; }
        public virtual DbSet<footer1> footer1 { get; set; }
        public virtual DbSet<footer2> footer2 { get; set; }
        public virtual DbSet<footer3> footer3 { get; set; }
        public virtual DbSet<footerdown1> footerdown1 { get; set; }
        public virtual DbSet<icon> icons { get; set; }
        public virtual DbSet<Last> Lasts { get; set; }
        public virtual DbSet<menu> menus { get; set; }
        public virtual DbSet<menucao> menucaos { get; set; }
        public virtual DbSet<menuContact> menuContacts { get; set; }
        public virtual DbSet<Most> Most { get; set; }
        public virtual DbSet<nav> navs { get; set; }
        public virtual DbSet<NewNew> NewNews { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsTiep> NewsTieps { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Trending> Trendings { get; set; }
        public virtual DbSet<video> videos { get; set; }
        public virtual DbSet<Viewd> Viewds { get; set; }
        public virtual DbSet<category3> category3 { get; set; }
        public virtual DbSet<category4> category4 { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
