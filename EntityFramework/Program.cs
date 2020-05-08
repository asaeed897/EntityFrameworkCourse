using System;

namespace EntityFrameworkCourse

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 7. Database-first Workflow

            // I am having error in installing Entity Framework. First I have error in installing due to same name of my project
            // as EntityFramework. I resolved it. But Now there is an another issue
            // I didn't understand it yet.
            //////~~~~~~~ERROR~~~~~~~~~~~~~//////
            // Missing function body in function declaration.
            //     At C:\Users\awais\.nuget\packages\entityframework\6.4.0\tools\EntityFramework6.PS2.psm1:241 char:5
            //     +      <<<< WarnIfOtherEFs 'Enable-Migrations'
            //     + CategoryInfo          : ParserError: (:)[], ParentContainsErrorRecordException
            //     + FullyQualifiedErrorId : MissingFunctionBody
            //
            //
            // Import - Module : The module to process 'EntityFramework6.PS2.psm1', listed in field 'ModuleToProcess' of module manifest 'C:\Users\awais\.nuget\packages\entityframework\6.4.0\tools
            //     \EntityFramework6.PS2.psd1' was not processed because no valid module was found in any module directory.
            //     At C:\Users\awais\.nuget\packages\entityframework\6.4.0\tools\init.ps1:11 char:18
            //     + Import - Module <<<< (Join - Path $PSScriptRoot 'EntityFramework6.PS2.psd1')
            // +CategoryInfo          : ResourceUnavailable: (EntityFramework6.PS2:String) [Import-Module], FileNotFoundException
            //     + FullyQualifiedErrorId : Modules_ModuleFileNotFound,Microsoft.PowerShell.Commands.ImportModuleCommand
        }
    }
}
