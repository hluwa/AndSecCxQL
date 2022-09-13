CxList source = Source_Intent() - All.FindByName("*getIntent");
source += All.FindByName("*getParcelableArrayExtra");
source += All.FindByName("*getParcelableArrayListExtra");
source += All.FindByName("*getParcelableExtra");
source += All.FindByName("*getParcelable");
source += All.FindByName("*getParcelableArray");
source += All.FindByName("*getParcelableArrayList");
source += All.FindByMemberAccess("Bundle.getSerializable");

CxList sink = All.FindByName("*sendBroadcast*").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*sendOrderedBroadcast*").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*startActivity*").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*startActivities*").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*startService*").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*bindService*").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*startForegroundService*").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*sendStickyBroadcast*").FindByType(typeof(MethodInvokeExpr));
sink += All.FindByName("*sendStickyOrderedBroadcast*").FindByType(typeof(MethodInvokeExpr));
sink = All.GetParameters(sink);
sink += All.FindAllReferences(sink).GetAssigner();
result += sink.DataInfluencedBy(source);
result += sink & source.FindByType(typeof(Param));