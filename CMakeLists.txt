# https://stackoverflow.com/a/55602125
cmake_minimum_required(VERSION 3.8)

project(win_forms_calc LANGUAGES CSharp)

# Include CMake utilities for CSharp, for WinForm and WPF application support.
include(CSharpUtilities)

# Define the executable, including any .cs files. 
# The .resx and other Properties files are optional here, but including them makes them visible in the VS solution for easy editing. 
add_executable(win_forms_calc
    App.config
    win_forms_calc.cs
    win_forms_calc.Designer.cs
    win_forms_calc.resx
    Program.cs
    Properties/AssemblyInfo.cs
    Properties/Resources.Designer.cs
    Properties/Resources.resx
    Properties/Settings.Designer.cs
    Properties/Settings.settings
)

# Define resources folder
source_group(Resources FILES Resources/pic.png)

# Set the .NET Framework version for the executable.
set_property(TARGET win_forms_calc PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.6.1")
# Set the executable to be 32-bit.
set_property(TARGET win_forms_calc PROPERTY WIN32_EXECUTABLE TRUE)
# Set the C# language version (defaults to 3.0).
set(CMAKE_CSharp_FLAGS "/langversion:latest")

# Set the source file properties for Windows Forms use.
csharp_set_windows_forms_properties(
    win_forms_calc.cs
    win_forms_calc.Designer.cs
    win_forms_calc.resx
    Program.cs
    Properties/AssemblyInfo.cs
    Properties/Resources.Designer.cs
    Properties/Resources.resx
    Properties/Settings.Designer.cs
    Properties/Settings.settings
	
)

# If necessary, link in other library dependencies that were built locally in this source tree.
# target_link_libraries(win_forms_calc calc_dll)

# If necessary, link in other library/DLL references, such as 3rd party libraries.
set_property(TARGET win_forms_calc PROPERTY 
    VS_DOTNET_REFERENCE_calc_dll /calc_dll/calc_dll.dll)

# https://stackoverflow.com/a/17229006/10279632
# searching for include directory
find_path(CALC_DLL_INCLUDE_DIR calc_dll/calc_dll.h)

# searching for library file
find_library(CALC_DLL_LIBRARY win_forms_calc)

if (CALC_DLL_INCLUDE_DIR AND CALC_DLL_LIBRARY)
    # you may need that if further action in your CMakeLists.txt depends
    # on detecting your library
    set(CALC_DLL_FOUND TRUE)

    # you may need that if you want to conditionally compile some parts
    # of your code depending on library availability
    add_definitions(-DHAVE_CALC_DLLGPU=1)

    # those two, you really need
    include_directories(${CALC_DLL_INCLUDE_DIR})
    set(CALC_DLL ${CALC_DLL} ${CALC_DLL_LIBRARY})
endif ()

# Link 3rd library to the target
target_link_libraries(win_forms_calc ${CALC_DLL})
target_link_libraries(win_forms_calc debug calc_dll/calc_dll.lib)

# Add in the .NET reference libraries.
set_property(TARGET win_forms_calc PROPERTY VS_DOTNET_REFERENCES
    "Microsoft.CSharp"
    "System"
    "System.Collections.Generic"
    "System.Linq"
    "System.Threading.Tasks"
    "System.Windows.Forms"
    "System.Collections.Generic"
    "System.ComponentModel"
    "System.Data"
    "System.Drawing"
    "System.Text"
)
set(CMAKE_CONFIGURATION_TYPES "Debug;Release" CACHE STRING "Configs" FORCE)