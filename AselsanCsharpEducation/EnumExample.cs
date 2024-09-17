using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{

    public enum Roles
    {
        Admin = 1,
        Manager = 2,
        Editor = 3
    }

    public class UserManagerClient
    {
     

        public void x()
        {   
            UserManager userManager = new UserManager();

            //roleNumberlari bilmek gerekiyor
            userManager.AssignToUser(roleNumber: 1, userName: "abidin");

            //Kodun okunabilirligi artiyor.
            userManager.AssignToUser(Roles.Admin, userName: "can");
        
        }

    }


    public class UserManager
    {
        //Enumsız kullanım
        public void AssignToUser(int roleNumber, string userName)
        {
            switch (roleNumber)
            {

                case 1:
                    Console.WriteLine("Admin");
                    break;

                case 2:
                    Console.WriteLine("Manager");
                    break;

                case 3:
                    Console.WriteLine("Editor");
                    break;
            }

        }

        //Okunabilirlik arttı enumlu kullanım
        public void AssignToUser(Roles roles , string userName) 
        { 
        
            switch(roles)
            {

                case Roles.Admin:
                    Console.WriteLine("Admin");
                    break;

                case Roles.Manager:
                    Console.WriteLine("Manager");
                    break;

                case Roles.Editor:
                    Console.WriteLine("Editor");
                    break;
            }

        
        }

    }


    public class SalaryCalculator
    {
        //Klasik switch case kullanım
        public decimal CalculateSalary(decimal baseSalary, Roles role)
        {

            decimal totalSalary = 0.00m;

            switch (role)
            {

                case Roles.Admin:
                    totalSalary =  baseSalary*2;
                    break;

                case Roles.Manager:
                    totalSalary = baseSalary * 3;
                    break;

                case Roles.Editor:
                    totalSalary = baseSalary * 4;
                    break;
            }

            return totalSalary; 

        }

        //Lambda expressionla switch kullanımı
        public decimal CalculateSalary2(decimal baseSalary, Roles role)
        {
            //C# 8.0 ve daha ust versiyonlarda kullanılabilir

            return role switch
            {
                Roles.Admin => baseSalary * 2,
                Roles.Manager => baseSalary * 3,
                Roles.Editor => baseSalary * 4,
                _ => throw new NotImplementedException(),
            };

        }

        public decimal CalculateSalary3(decimal baseSalary, Roles role)
        {

            if(role is Roles.Admin)         
                return baseSalary * 2;
            
            if(role is Roles.Manager) 
                return baseSalary * 3;

            if(role is Roles.Editor)
                return baseSalary * 4;

            throw new NotImplementedException();

        }

    }


}
