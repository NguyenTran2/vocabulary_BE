﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VocabularyProject.Models;

#nullable disable

namespace VocabularyProject.Migrations
{
    [DbContext(typeof(VocabularyDbContext))]
    [Migration("20230402180623_8")]
    partial class _8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Service.Models.Folders", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Folders");
                });

            modelBuilder.Entity("Service.Models.LearnedDates", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("LearnedDates");
                });

            modelBuilder.Entity("VocabularyProject.Models.Set", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FoldersID")
                        .HasColumnType("int");

                    b.Property<string>("FoldersIDs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameVi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NewestDateLearn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("UserSharedIDs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("FoldersID");

                    b.HasIndex("UserID");

                    b.ToTable("Sets");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "",
                            FoldersIDs = "",
                            Name = "Contracts",
                            NameVi = "",
                            NewestDateLearn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = 1
                        },
                        new
                        {
                            ID = 2,
                            Description = "",
                            FoldersIDs = "",
                            Name = "Marketing",
                            NameVi = "",
                            NewestDateLearn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = 2
                        },
                        new
                        {
                            ID = 3,
                            Description = "",
                            FoldersIDs = "",
                            Name = "Warrranties",
                            NameVi = "",
                            NewestDateLearn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = 2
                        },
                        new
                        {
                            ID = 4,
                            Description = "",
                            FoldersIDs = "",
                            Name = "Business Planning",
                            NameVi = "",
                            NewestDateLearn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = 2
                        },
                        new
                        {
                            ID = 5,
                            Description = "",
                            FoldersIDs = "",
                            Name = "Conferences",
                            NameVi = "",
                            NewestDateLearn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = 2
                        },
                        new
                        {
                            ID = 6,
                            Description = "",
                            FoldersIDs = "",
                            Name = "Computers and the Internet",
                            NameVi = "",
                            NewestDateLearn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = 2
                        });
                });

            modelBuilder.Entity("VocabularyProject.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkAvatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Account = "",
                            LinkAvatar = "",
                            Name = "LHN",
                            Password = "LHN"
                        },
                        new
                        {
                            ID = 2,
                            Account = "",
                            LinkAvatar = "",
                            Name = "VTAT",
                            Password = "VTAT"
                        });
                });

            modelBuilder.Entity("VocabularyProject.Models.Word", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("English")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SetID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TiengViet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("SetID");

                    b.ToTable("Words");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            English = "abide by",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "tuân theo"
                        },
                        new
                        {
                            ID = 2,
                            English = "agreement",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "Thoả thuận"
                        },
                        new
                        {
                            ID = 3,
                            English = "assurance",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "đảm bảo"
                        },
                        new
                        {
                            ID = 4,
                            English = "determine",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "giải quyết vấn đề"
                        },
                        new
                        {
                            ID = 5,
                            English = "engage",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "thuê, mướn"
                        },
                        new
                        {
                            ID = 6,
                            English = "establish",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "thành lập"
                        },
                        new
                        {
                            ID = 7,
                            English = "obligate",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "bắt buộc, ép buộc"
                        },
                        new
                        {
                            ID = 8,
                            English = "party",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "nhóm làm việc chung"
                        },
                        new
                        {
                            ID = 9,
                            English = "provision",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "sự cung cấp"
                        },
                        new
                        {
                            ID = 10,
                            English = "Resolve",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "Giải quyết"
                        },
                        new
                        {
                            ID = 11,
                            English = "specify",
                            SetID = 1,
                            Status = 0,
                            TiengViet = "chỉ rõ, định rõ"
                        },
                        new
                        {
                            ID = 12,
                            English = "attract",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "hấp dẫn, lôi cuốn, thu hút"
                        },
                        new
                        {
                            ID = 13,
                            English = "compare",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "so sánh, đối chiếu"
                        },
                        new
                        {
                            ID = 14,
                            English = "competition",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "cạnh tranh, tranh giành, thi đấu"
                        },
                        new
                        {
                            ID = 15,
                            English = "consume",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "tiêu thụ, tiêu dùng"
                        },
                        new
                        {
                            ID = 16,
                            English = "convince",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "Thuyết phục"
                        },
                        new
                        {
                            ID = 17,
                            English = "currently",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "hiện thời, hiện nay, lúc này"
                        },
                        new
                        {
                            ID = 18,
                            English = "fad",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "mốt nhất thời, sự thích thú tạm thời; dở hơi, gàn dở"
                        },
                        new
                        {
                            ID = 19,
                            English = "inspiration",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "‹sự/người/vật› truyền cảm hứng, gây cảm hứng"
                        },
                        new
                        {
                            ID = 20,
                            English = "market",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "thị trường, chợ, nơi mua bán sản phẩm"
                        },
                        new
                        {
                            ID = 21,
                            English = "persuasion",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "thuyết phục, làm cho tin"
                        },
                        new
                        {
                            ID = 22,
                            English = "productive",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "sản xuất, sinh sản; sinh lợi nhiều, có hiệu quả"
                        },
                        new
                        {
                            ID = 23,
                            English = "satisfaction",
                            SetID = 2,
                            Status = 0,
                            TiengViet = "sự làm thỏa mãn, sự hài lòng"
                        });
                });

            modelBuilder.Entity("Service.Models.Folders", b =>
                {
                    b.HasOne("VocabularyProject.Models.User", "Users")
                        .WithMany("Folders")
                        .HasForeignKey("UserID")
                        .HasConstraintName("FK_Folders_Users");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Service.Models.LearnedDates", b =>
                {
                    b.HasOne("VocabularyProject.Models.User", "Users")
                        .WithMany("LearnedDates")
                        .HasForeignKey("UserID")
                        .HasConstraintName("FK_LearnedDates_Users");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VocabularyProject.Models.Set", b =>
                {
                    b.HasOne("Service.Models.Folders", null)
                        .WithMany("Sets")
                        .HasForeignKey("FoldersID");

                    b.HasOne("VocabularyProject.Models.User", "Users")
                        .WithMany("Sets")
                        .HasForeignKey("UserID")
                        .HasConstraintName("FK_Sets_Users");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VocabularyProject.Models.Word", b =>
                {
                    b.HasOne("VocabularyProject.Models.Set", "Sets")
                        .WithMany("Words")
                        .HasForeignKey("SetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Words_Sets");

                    b.Navigation("Sets");
                });

            modelBuilder.Entity("Service.Models.Folders", b =>
                {
                    b.Navigation("Sets");
                });

            modelBuilder.Entity("VocabularyProject.Models.Set", b =>
                {
                    b.Navigation("Words");
                });

            modelBuilder.Entity("VocabularyProject.Models.User", b =>
                {
                    b.Navigation("Folders");

                    b.Navigation("LearnedDates");

                    b.Navigation("Sets");
                });
#pragma warning restore 612, 618
        }
    }
}
