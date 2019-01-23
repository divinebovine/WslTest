# WslTest

This repository is a test project that documents the inconsistent behavior between this repository when checkouted via gitbash vs windows subsystem for linux (WSL). Recently, per-directory case sensitivity was introduced to improve the interoperability with WSL [source](https://blogs.msdn.microsoft.com/commandline/2018/02/28/per-directory-case-sensitivity-and-wsl/). This seems to be the change that initiated at least one of the issues documented here.
### gitbash behavior

Works as expected

### WSL behavior

1. Code in Global.asax.cs is not executed resulting in a 404.
1. ConfigurationManager does not load settings from Web.config

### Workarounds

1. Renaming Global.asax and Global.asax.cs to global.asax and global.asax.cs and updating the csproj to reflect these changes will cause the code in the global.asax.cs to execute.
1. No workaround for loading the Web.config settings has been found yet.