cd C:\Users\Daniel Contreras\source\repos\DaniandCharlie\Students.Presentation.WinSite
nugetpack .\Students.Presentation.WinSite.csproj -IncludeReferencedProjects

move Students.Presentation.WinSite.1.0.0.nupkg "C:\Users\Daniel Contreras\source\Nuget paquetes"



cd C:\Users\Daniel Contreras\source\repos\DaniandCharlie\Students.Business.Logic
nuget pack .\Students.Business.Logic.csproj -IncludeReferencedProjects

move Students.Business.Logic.1.0.0.nupkg "C:\Users\Daniel Contreras\source\Nuget paquetes"

cd C:\Users\Daniel Contreras\source\repos\DaniandCharlie\Students.Common.Logic
nuget pack .\Students.Common.Logic.csproj -IncludeReferencedProjects

move Students.Common.Logic.1.0.0.nupkg "C:\Users\Daniel Contreras\source\Nuget paquetes"

cd C:\Users\Daniel Contreras\source\repos\DaniandCharlie\Students.DataAccess.Dao
nuget pack .\Students.DataAccess.Dao.csproj -IncludeReferencedProjects

move Students.DataAccess.Dao.1.0.0.nupkg "C:\Users\Daniel Contreras\source\Nuget paquetes"



PAUSE