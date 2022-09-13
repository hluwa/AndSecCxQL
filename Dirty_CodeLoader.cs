CxList source = Source_Android_All();
CxList sink = All.FindByMemberAccess("System.load");
sink += All.FindByMemberAccess("Runtime.load");
sink += All.FindByName("*DexClassLoader");
sink += All.FindByName("*PathClassLoader");
sink += All.FindByName("*BasePathClassLoader");
result += sink.DataInfluencedBy(source);