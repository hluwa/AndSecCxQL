CxList source = Source_Android_All();
CxList sink = All.FindByName("*Settings.Global.put*").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*Settings.Secure.put*").FindByType(typeof(MethodInvokeExpr));
result += sink.DataInfluencedBy(source);
result += sink & source.FindByType(typeof(Param));