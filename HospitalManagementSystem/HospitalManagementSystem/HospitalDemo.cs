using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            
            var hospital = new Hospital();

            
            Console.WriteLine("--- 1. Реєстрація лікарів ---");
            var therapist = new Doctor(1, "Петренко Василь", "Терапевт");
            var surgeon = new Doctor(2, "Іваненко Олег", "Хірург");
            var cardiologist = new Doctor(3, "Сидоренко Анна", "Кардіолог");
            hospital.AddDoctor(therapist);
            hospital.AddDoctor(surgeon);
            hospital.AddDoctor(cardiologist);
            Console.WriteLine();

            Console.WriteLine("--- 2. Реєстрація пацієнтів ---");
            var patient1 = new Patient(101, "Коваленко Тарас", 45);
            var patient2 = new Patient(102, "Шевченко Марія", 32);
            var patient3 = new Patient(103, "Григоренко Іван", 58);
            var patient4 = new Patient(104, "Лисенко Олена", 25);
            hospital.RegisterPatient(patient1);
            hospital.RegisterPatient(patient2);
            hospital.RegisterPatient(patient3);
            hospital.RegisterPatient(patient4);
            Console.WriteLine();

            
            Console.WriteLine("--- 3. Створення палат ---");
            hospital.CreateRoom(new HospitalRoom(205, 1));
            hospital.CreateRoom(new HospitalRoom(206, 2));
            hospital.CreateRoom(new HospitalRoom(301, 1));
            Console.WriteLine();

           
            Console.WriteLine("--- 4. Госпіталізація пацієнтів ---");
            hospital.HospitalizePatient(101, 205); 
            hospital.HospitalizePatient(102, 206); 
            hospital.HospitalizePatient(103, 206); 
            hospital.HospitalizePatient(104, 206); 
            Console.WriteLine();

            
            Console.WriteLine("--- 5. Додавання медичних записів ---");
            hospital.AddMedicalRecord(new MedicalRecord(patient1, therapist, DateTime.Now.AddDays(-10), "Діагноз: ГРВІ."));
            hospital.AddMedicalRecord(new MedicalRecord(patient2, surgeon, DateTime.Now.AddDays(-5), "Плановий огляд."));
            hospital.AddMedicalRecord(new MedicalRecord(patient1, cardiologist, DateTime.Now.AddDays(-40), "Скарги на біль у серці."));
            Console.WriteLine();

            
            Console.WriteLine($"--- 6. ІСТОРІЯ ПАЦІЄНТА: {patient1.Name} ---");
            var history = hospital.GetPatientHistory(101); 
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            
            Console.WriteLine("--- 7. Загальна статистика ---");
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}

