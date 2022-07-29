Mono binary reference assemblies
================================

Built using csc 2.1.0.

Adding a new .NET profile
-------------------------

Use the following steps (we're using 4.7.1 as example):

1. Copy existing `v4.7/Makefile` and `src/v4.7/*` to new folders and commit
2. Update `PROFILE` variable in `v4.7.1/Makefile`
3. Wire up new profile in `Makefile` in repo root
4. Run the generation script `./generate-refasm-sources.sh v4.7.1 some/path/to/netfx/referenceassemblies`
5. Revert deletion of `*.extra.cs`
6. Revert changes that remove `#if / #endif`
7. Revert suspicious changes to:
    - `Accessibility.cs` (bug in GenApi)
    - `Microsoft.VisualBasic.cs` (bug in GenApi and wrong AssemblyCopyright/Product attribute)
    - `Microsoft.VisualC.cs` (bug in GenApi)
    - `System.Data.Linq.cs` (bug in GenApi)
    - `System.Deployment.cs` (we only have stub assemblies)
    - `System.Runtime.DurableInstancing.cs` (bug in GenApi)
    - `System.Security.cs` (bug in GenApi)
    - `System.Web.Mobile.cs` (we only have stub assemblies)
    - `System.Workflow.*.cs` (we only have stub assemblies)
8. Add new assemblies/facades to `v4.7.1/Makefile`
9. Run `make -C v4.7.1` and ensure everything compiles
