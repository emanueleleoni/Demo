﻿// <auto-generated />
using LK2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace LK2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180525091501_ChangeSelection")]
    partial class ChangeSelection
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("LK2.Models.CategoryProduct", b =>
                {
                    b.Property<int>("CategoryProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<int>("Position");

                    b.HasKey("CategoryProductID");

                    b.ToTable("CategoryProducts");
                });

            modelBuilder.Entity("LK2.Models.CategoryProductLanguage", b =>
                {
                    b.Property<int>("CategoryProductID");

                    b.Property<int>("LanguageID");

                    b.Property<string>("Name");

                    b.HasKey("CategoryProductID", "LanguageID");

                    b.HasIndex("LanguageID");

                    b.ToTable("CategoryProductLanguages");
                });

            modelBuilder.Entity("LK2.Models.Language", b =>
                {
                    b.Property<int>("LanguageID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.HasKey("LanguageID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("LK2.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryProductID");

                    b.Property<string>("Image");

                    b.Property<double>("Price");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("LK2.Models.ProductCategoryProductPosition", b =>
                {
                    b.Property<int>("ProductID");

                    b.Property<int>("CategoryProductID");

                    b.Property<int>("Position");

                    b.Property<int>("Quantity");

                    b.Property<string>("Selection");

                    b.HasKey("ProductID", "CategoryProductID", "Position");

                    b.HasAlternateKey("CategoryProductID", "Position", "ProductID");

                    b.ToTable("ProductCategoryProductPositions");
                });

            modelBuilder.Entity("LK2.Models.ProductLanguage", b =>
                {
                    b.Property<int>("ProductID");

                    b.Property<int>("LanguageID");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ProductID", "LanguageID");

                    b.HasAlternateKey("LanguageID", "ProductID");

                    b.ToTable("ProductLanguages");
                });

            modelBuilder.Entity("LK2.Models.CategoryProductLanguage", b =>
                {
                    b.HasOne("LK2.Models.CategoryProduct", "CategoryProduct")
                        .WithMany("CategoryProductLanguages")
                        .HasForeignKey("CategoryProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LK2.Models.Language", "Language")
                        .WithMany("CategoryProductLanguages")
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LK2.Models.Product", b =>
                {
                    b.HasOne("LK2.Models.CategoryProduct", "CategoryProduct")
                        .WithMany("Products")
                        .HasForeignKey("CategoryProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LK2.Models.ProductCategoryProductPosition", b =>
                {
                    b.HasOne("LK2.Models.CategoryProduct", "CategoryProduct")
                        .WithMany("ProductCategoryProductPositions")
                        .HasForeignKey("CategoryProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LK2.Models.Product", "Product")
                        .WithMany("ProductCategoryProductPositions")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LK2.Models.ProductLanguage", b =>
                {
                    b.HasOne("LK2.Models.Language", "Language")
                        .WithMany("ProductLanguages")
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LK2.Models.Product", "Product")
                        .WithMany("ProductLanguages")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
