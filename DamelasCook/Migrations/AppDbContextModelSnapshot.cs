﻿// <auto-generated />
using System;
using DamelasCook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DamelasCook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("DamelasCook.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ExibirHome")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExibirHome = true,
                            Foto = "/img/categorias/1.jpg",
                            Nome = "Acompanhamentos"
                        },
                        new
                        {
                            Id = 2,
                            ExibirHome = false,
                            Foto = "/img/categorias/2.jpg",
                            Nome = "Bebidas"
                        },
                        new
                        {
                            Id = 3,
                            ExibirHome = true,
                            Foto = "/img/categorias/3.jpg",
                            Nome = "Bolos"
                        },
                        new
                        {
                            Id = 4,
                            ExibirHome = true,
                            Foto = "/img/categorias/4.jpg",
                            Nome = "Carnes"
                        },
                        new
                        {
                            Id = 5,
                            ExibirHome = true,
                            Foto = "/img/categorias/5.jpg",
                            Nome = "Frango"
                        },
                        new
                        {
                            Id = 6,
                            ExibirHome = false,
                            Foto = "/img/categorias/6.jpg",
                            Nome = "Lanches"
                        },
                        new
                        {
                            Id = 7,
                            ExibirHome = false,
                            Foto = "/img/categorias/7.jpg",
                            Nome = "Massas"
                        },
                        new
                        {
                            Id = 8,
                            ExibirHome = false,
                            Foto = "/img/categorias/8.jpg",
                            Nome = "Molhos"
                        },
                        new
                        {
                            Id = 9,
                            ExibirHome = true,
                            Foto = "/img/categorias/9.jpg",
                            Nome = "Pratos Principais"
                        },
                        new
                        {
                            Id = 10,
                            ExibirHome = false,
                            Foto = "/img/categorias/10.jpg",
                            Nome = "Peixes"
                        });
                });

            modelBuilder.Entity("DamelasCook.Models.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataComentario")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ReceitaId")
                        .HasColumnType("int");

                    b.Property<string>("TextoComentario")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ReceitaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("DamelasCook.Models.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Ingrediente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Carne Moída"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Pimentão Verde"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Pimentão Vermelho"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Pimentão Amarelo"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Cebola"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Curry"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Pimenta Calabresa"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Páprica Picante"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Sal"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Orégano"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Pão Sirio"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Cream Cheese"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "Cheddar"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "Azeite"
                        });
                });

            modelBuilder.Entity("DamelasCook.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("Dificuldade")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Preparo")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("varchar(8000)");

                    b.Property<int>("Rendimento")
                        .HasColumnType("int");

                    b.Property<string>("TempoPreparo")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Receita");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 4,
                            Descricao = "Prato perfeito para um lanche rápido ou mesmo uma refeição picante. Carne moída, pimentões, temperos e muito queijooooo",
                            Dificuldade = 1,
                            Foto = "/img/receitas/1.jpg",
                            Nome = "Carne Moída Mexicana",
                            Preparo = "Comece pela preparação dos ingredientes, pique os pimentões e a cebola em pequenos cubos, se preferir você também pode usar um processador de alimentos.Coloque a carne moída para fritar em uma panela com um pouco de azeite.Quando a carne moída já não estiver mais crua, adicione os pimentões e a cebola, mexendo bem para misturar todos os ingredientes.Aguarde alguns instante e adicione os temperos, mexendo novamente para misturar.Frite por mais alguns minutos a carne com os demais ingredientes.Adicione o Cream Cheese e o Queijo Cheddar, mexendo bem para evitar que queime o fundo e ajudar os queijos a derreterem.Quando os queijos já estiverem bem derretidos e misturados com os demais ingredientes, sirva acompanhado do Pão Sirio ou de Doritos.",
                            Rendimento = 3,
                            TempoPreparo = "20 minutos"
                        });
                });

            modelBuilder.Entity("DamelasCook.Models.ReceitaIngrediente", b =>
                {
                    b.Property<int>("ReceitaId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("IngredienteId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<string>("Quantidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("ReceitaId", "IngredienteId");

                    b.HasIndex("IngredienteId");

                    b.ToTable("ReceitaIngresiente");

                    b.HasData(
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 1,
                            Quantidade = "500g"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 3,
                            Quantidade = "1 pequeno"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 4,
                            Quantidade = "1 pequeno"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 5,
                            Quantidade = "1 pequeno"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 6,
                            Quantidade = "1 colher sopa"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 7,
                            Quantidade = "1 colher sopa"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 8,
                            Quantidade = "1 colher sopa"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 9,
                            Quantidade = "1 colher sopa"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 10,
                            Quantidade = "1 colher sopa"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 11,
                            Quantidade = "A vontade"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 12,
                            Quantidade = "200g"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 13,
                            Quantidade = "200g"
                        },
                        new
                        {
                            ReceitaId = 1,
                            IngredienteId = 14,
                            Quantidade = "Um pouco"
                        });
                });

            modelBuilder.Entity("DamelasCook.Models.Usuario", b =>
                {
                    b.Property<string>("UsuarioId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            UsuarioId = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                            DataNascimento = new DateTime(2008, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "/img/usuarios/avatar.png",
                            Nome = "Laura Bressanin Ortigosa"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "bec71b05-8f3d-4849-88bb-0e8d518d2de8",
                            Name = "Usuário",
                            NormalizedName = "USUÁRIO"
                        },
                        new
                        {
                            Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                            Name = "Moderador",
                            NormalizedName = "MODERADOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5d475db9-aec1-4468-9a25-0e03d07246fa",
                            Email = "admin@damelascook.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@DAMELASCOOK.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEMrkFokxuPg7e3xFqEOKDwkMdcjVviwuPdapDTeqxvyyRBHx2sNJ1qcMsKEuGSlOcw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f5ed03fc-59f9-4056-b8e8-41dadd5cf3de",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                            RoleId = "0b44ca04-f6b0-4a8f-a953-1f2330d30894"
                        },
                        new
                        {
                            UserId = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                            RoleId = "bec71b05-8f3d-4849-88bb-0e8d518d2de8"
                        },
                        new
                        {
                            UserId = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                            RoleId = "ddf093a6-6cb5-4ff7-9a64-83da34aee005"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DamelasCook.Models.Comentario", b =>
                {
                    b.HasOne("DamelasCook.Models.Receita", "Receita")
                        .WithMany()
                        .HasForeignKey("ReceitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DamelasCook.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receita");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("DamelasCook.Models.Receita", b =>
                {
                    b.HasOne("DamelasCook.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("DamelasCook.Models.ReceitaIngrediente", b =>
                {
                    b.HasOne("DamelasCook.Models.Ingrediente", "Ingrediente")
                        .WithMany("Receitas")
                        .HasForeignKey("IngredienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DamelasCook.Models.Receita", "Receita")
                        .WithMany("Ingredientes")
                        .HasForeignKey("ReceitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingrediente");

                    b.Navigation("Receita");
                });

            modelBuilder.Entity("DamelasCook.Models.Usuario", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "ContaUsuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContaUsuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DamelasCook.Models.Ingrediente", b =>
                {
                    b.Navigation("Receitas");
                });

            modelBuilder.Entity("DamelasCook.Models.Receita", b =>
                {
                    b.Navigation("Ingredientes");
                });
#pragma warning restore 612, 618
        }
    }
}
