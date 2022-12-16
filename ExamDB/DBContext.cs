using ExamDB.Models;
using Microsoft.EntityFrameworkCore;
using ExamDB.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDB
{
    public class DBContext : DbContext
    {
        private string _connectionString = "Server=DESKTOP-2A9VHRE;Database=Exam;Trusted_Connection=True;TrustServerCertificate=True;";
        public DBContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DBContext()
        {

        }

        public DbSet<ClientEntity> Client { get; set; }
        public DbSet<AppointmentEntity> Appointment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ClientEntity>().HasData(new List<ClientEntity>
            {
                new ClientEntity
                {
                    Id = 1,
                    ClientName = "James Johnson",
                    HairdresserName = "Sandy Brown",
                    WorkType = WorkType.Coloring
                },
                new ClientEntity
                {
                    Id = 2,
                    ClientName = "Simon Smiths",
                    HairdresserName = "Sandy Brown",
                    WorkType = WorkType.Trimming
                },
                new ClientEntity
                {
                    Id = 3,
                    ClientName = "Jessica Mayor",
                    HairdresserName = "Sirius Black",
                    WorkType = WorkType.Cutting
                },
                new ClientEntity
                {
                    Id = 4,
                    ClientName = "Harry Windsor",
                    HairdresserName = "Sandy Brown",
                    WorkType = WorkType.Trimming
                },
                new ClientEntity
                {
                    Id = 5,
                    ClientName = "Ron Weasley",
                    HairdresserName = "Sandy Brown",
                    WorkType = WorkType.Coloring & WorkType.Cutting
                },
                new ClientEntity
                {
                    Id = 6,
                    ClientName = "Jinny Johnson",
                    HairdresserName = "Sirius Black",
                    WorkType = WorkType.Trimming & WorkType.Styling
                }

            });

            modelBuilder.Entity<AppointmentEntity>().HasData(new List<AppointmentEntity>
            {
                new AppointmentEntity
                {
                    Id = 1,
                    AppointmentDateTime = new DateTime(2022,12, 30, 9, 45, 0),
                    ClientID = 1

                },
                new AppointmentEntity
                {
                    Id = 2,
                    AppointmentDateTime = new DateTime(2022,12, 30, 10, 45, 0),
                    ClientID = 2
                },
                new AppointmentEntity
                {
                    Id = 3,
                    AppointmentDateTime = new DateTime(2022,12, 30, 11, 15, 0),
                    ClientID = 3
                },
                new AppointmentEntity
                {
                    Id = 4,
                    AppointmentDateTime = new DateTime(2022,12, 30, 14, 30, 0),
                    ClientID = 4
                },
                new AppointmentEntity
                {
                    Id = 5,
                    AppointmentDateTime = new DateTime(2022,12, 30, 16, 0, 0),
                    ClientID = 5
                },
                new AppointmentEntity
                {
                    Id = 6,
                    AppointmentDateTime = new DateTime(2022,12, 30, 18, 10, 0),
                    ClientID = 6
                }
            }); ;


        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_connectionString);
            base.OnConfiguring(builder);
        }
    }
}
