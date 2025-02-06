﻿using System;
using CompanyAndDepartmentsComposition;

class Program
{
    static void Main()
    {
        Company company = new Company("Capgemini");
        company.addDepartment("IT");
        company.addDepartment("HR");

        Department itDept = new Department("IT");
        itDept.addEmployee("vaibhav");
        itDept.addEmployee("aditya");

        Department hrDept = new Department("HR");
        hrDept.addEmployee("Rohit");

        company.showDepartments();
        hrDept.showEmployees();

        itDept.showEmployees();
    }
}