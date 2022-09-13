CxList source = Source_Android_All();
CxList processStart = All.FindByMemberAccess("ProcessBuilder.start");
CxList processCommandWithStart = All.FindByMemberAccess("ProcessBuilder.command").GetTargetOfMembers().DataInfluencingOn(processStart).GetMembersOfTarget();
CxList sink = All.FindByMemberAccess("Runtime.exec");
sink.Add(All.FindByMemberAccess("getRuntime.exec"));
sink.Add(All.FindByMemberAccess("System.exec"));
sink.Add(processStart);
sink.Add(All.GetParameters(processCommandWithStart));

result += sink.DataInfluencedBy(source);
result += sink & source.FindByType(typeof(Param));