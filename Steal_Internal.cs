CxList source = Source_Android_All();
CxList sink = All.FindByName("*getUriForFile").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*setDatabasePath").FindByType(typeof(MethodInvokeExpr));
sink += All.GetParameters(All.FindByName("*WebResourceResponse")).FindByType("*InputStream");
result += sink.DataInfluencedBy(source);
result += sink & source.FindByType(typeof(Param));

CxList settings = All.FindByName("*setAllowFileAccess").FindByType(typeof(MethodInvokeExpr));
settings += All.FindByName("*setAllowContentAccess").FindByType(typeof(MethodInvokeExpr));
settings += All.FindByName("*setAllowUniversalAccessFromFileURLs").FindByType(typeof(MethodInvokeExpr));
settings += All.FindByName("*setAllowFileAccessFromFileURLs").FindByType(typeof(MethodInvokeExpr));
//settings += All.FindByName("*setJavaScriptEnabled").FindByType(typeof(MethodInvokeExpr));
CxList parameters = All.GetParameters(settings);

CxList trues = All.FindByName("true").FindByType(typeof(BooleanLiteral));
result += trues.InfluencingOn(parameters);
result += parameters.FindByName("true");
result += source.InfluencingOn(All.FindByName("*uploadfile", false));