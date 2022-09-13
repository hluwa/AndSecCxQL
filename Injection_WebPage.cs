CxList source = Source_Android_All();
CxList sink = All.FindByName("*loadUrl").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*postUrl").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*loadData").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*loadDataWithBaseURL").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*evaluateJavascript*").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*postWebMessage*").FindByType(typeof(MethodInvokeExpr));

result += sink.DataInfluencedBy(source);
result += sink & source.FindByType(typeof(Param));