using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Utilities;

public class DataSource
{

    public static object[][] InvalidLoginCredentials()
    {
        object[] dataSet1 = new object[3];//number of parameters
        dataSet1[0] = "rani";
        dataSet1[1] = "naga123";
        dataSet1[2] = "Invalidcredentials";


        object[] dataSet2 = new object[3];
        dataSet2[0] = "syed";
        dataSet2[1] = "syed123";
        dataSet2[2] = "Invalidcredentials";

        object[][] main = new object[2][];//number of testcases
        main[0] = dataSet1;
        main[1] = dataSet2;
        return main;
    }
    public static object[][] EmployeeTestData()
    {
        object[] dataSet3 = new object[5];//number of parameters
        dataSet3[0] = "rani";
        dataSet3[1] = "naga123";
        dataSet3[2] = "naga";
        dataSet3[3] = "n";
        dataSet3[4] = "ranii";


        object[] dataSet4 = new object[5];
        dataSet4[0] = "syed";
        dataSet4[1] = "syed123";
        dataSet4[2] = "syed";
        dataSet4[3] = "karim";
        dataSet4[4] = "karimulla";


        object[][] main = new object[2][];//number of testcases
        main[0] = dataSet3;
        main[1] = dataSet4;
        return main;
    }



}
