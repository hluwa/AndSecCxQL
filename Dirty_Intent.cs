CxList source = Source_Android_All();
CxList sink = All.FindByName("*setClassName").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*setAction").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*addAction").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*setComponent").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*Intent.parseUri").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("Intent");
sink = All.GetParameters(sink);
sink += All.GetParameters(All.FindByName("*setResult*").FindByType(typeof(MethodInvokeExpr))).FindByType("Intent");
sink += All.FindAllReferences(sink).GetAssigner();

result += sink.DataInfluencedBy(source);
result += sink & source.FindByType(typeof(Param));