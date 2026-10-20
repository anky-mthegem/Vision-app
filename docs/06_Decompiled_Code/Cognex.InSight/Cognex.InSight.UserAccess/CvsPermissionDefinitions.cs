using System.ComponentModel;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.UserAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class CvsPermissionDefinitions
{
	public static class General
	{
		public const string All = "ALL";

		public const string AllPath = "cn=ALL";
	}

	public static class InSight
	{
		public const string AllInSight = "IS";

		public const string AllInSightPath = "cn=IS, cn=ALL";

		public const string InSightConfig = "IS.CFG";

		public const string InSightConfigPath = "cn=IS.CFG, cn=IS, cn=ALL";

		public const string InSightClassicConfig = "IS.CLASSICCFG";

		public const string InSightProtectedConfig = "IS.PROTECTEDCFG";

		public const string InSightImage = "IS.IMAGE";

		public const string InSightImagePath = "cn=IS.IMAGE, cn=IS, cn=ALL";

		public const string InSightMaintenance = "IS.MNT";

		public const string InSightMaintenancePath = "cn=IS.MNT, cn=IS, cn=ALL";

		public const string InSightFileManage = "IS.FILE";

		public const string InSightFileManagePath = "cn=IS.FILE, cn=IS.MNT, cn=IS, cn=ALL";

		public const string InSightReadFiles = "IS.OPENFILE";

		public const string InSightReadFilesPath = "cn=IS.OPENFILE, cn=IS.FILE, cn=IS.MNT, cn=IS, cn=ALL";

		public const string InSightWriteFiles = "IS.WRITEFILE";

		public const string InSightWriteFilesPath = "cn=IS.WRITEFILE, cn=IS.FILE, cn=IS.MNT, cn=IS, cn=ALL";

		public const string InSightSaveImage = "IS.SAVEIMAGE";

		public const string InSightOperations = "IS.OPS";

		public const string InSightOperationsPath = "cn=IS.OPS, cn=IS, cn=ALL";

		public const string InSightAllJob = "IS.JOB";

		public const string InSightAllJobPath = "cn=IS.JOB, cn=IS, cn=ALL";

		public const string InSightOpenJob = "IS.OPENJOB";

		public const string InSightOpenJobPath = "cn=IS.OPENJOB, cn=IS.JOB, cn=IS, cn=ALL";

		public const string InSightSaveAll = "IS.SAVEALL";

		public const string InSightSaveAllPath = "cn=IS.SAVEALL, cn=IS.JOB, cn=IS, cn=ALL";

		public const string InSightSaveJob = "IS.SAVE";

		public const string InSightSaveJobPath = "cn=IS.SAVE, cn=IS.SAVEALL, cn=IS.JOB, cn=IS, cn=ALL";

		public const string InSightSaveJobAs = "IS.SAVEJOBAS";

		public const string InSightSaveJobAsPath = "cn=IS.SAVEJOBAS, cn=IS.SAVEALL, cn=IS.JOB, cn=IS, cn=ALL";

		public const string InSightEditJob = "IS.EDITJOB";

		public const string InSightEditJobPath = "cn=IS.EDITJOB, cn=IS.JOB, cn=IS, cn=ALL";

		public const string InSightConfigJob = "IS.CFGJOB";

		public const string InSightConfigJobPath = "cn=IS.CFGJOB, cn=IS.EDITJOB, cn=IS.JOB, cn=IS, cn=ALL";

		public const string InSightAllCustom = "IS.CSTMALL";

		public const string InSightAllCustomPath = "cn=IS.CSTMALL, cn=IS.CFGJOB, cn=IS.EDITJOB, cn=IS.JOB, cn=IS, cn=ALL";

		public const string InSightSecondaryAuthorize = "IS.2AUTH";

		public const string InSightSecondaryAuthorizePath = "cn=IS.2AUTH, cn=IS.JOB, cn=IS, cn=ALL";

		public const string InSightJobEditor = "IS.JOBEDITOR";

		public const string InSightOnlineOffline = "IS.PUTONLINE";

		public const string InSightTrigger = "IS.TRIGGER";
	}

	public static class ISE
	{
		public const string ISEAll = "ISE";

		public const string ISEAllPath = "cn=ISE, cn=ALL";

		public const string ISETestRun = "ISE.TESTRUN";

		public const string ISETestRunPath = "cn=ISE.TESTRUN, cn=ISE, cn=ALL";

		public const string ISEOperations = "ISE.OPS";

		public const string ISEOperationsPath = "cn=ISE.OPS, cn=ISE, cn=ALL";

		public const string ISEProtectedOperations = "ISE.PROTECTEDOPS";

		public const string ISEJobEditor = "ISE.JOBEDITOR";

		public const string ISEJobEditorPath = "cn=ISE.JOBEDITOR, cn=ISE, cn=ALL";

		public const string ISEConfig = "ISE.CFG";

		public const string ISEConfigPath = "cn=ISE.CFG, cn=ISE, cn=ALL";

		public const string ISEConfigLayout = "ISE.CFGLAYOUT";

		public const string ISEConfigLayoutPath = "cn=ISE.CFGLAYOUTcn=ISE.CFG, cn=ISE, cn=ALL";

		public const string ISEProtectedConfig = "ISE.PROTECTEDCFG";

		public const string ISEMaintenance = "ISE.MNT";

		public const string ISEMaintenancePath = "cn=ISE.MNT, cn=ISE, cn=ALL";

		public const string ISEBackup = "ISE.BKUP";

		public const string ISEBackupPath = "cn=ISE.BKUP, cn=ISE.MNT, cn=ISE, cn=ALL";

		public const string ISEExit = "ISE.EXIT";

		public const string ISEExitPath = "cn=ISE.EXIT, cn=ISE.MNT, cn=ISE, cn=ALL";
	}

	public static class CDS
	{
		public const string CDSAll = "CDS";

		public const string CDSServer = "CDS.SERVERSETTINGS";

		public const string CDSOperations = "CDS.MANAGE";

		public const string CDSUserManagement = "CDS.ACCOUNTMANAGEMENT";
	}

	internal static readonly string[] ArrayOfEveryPermission;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string CleanVirtualPermission(string permission)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (0 == 0)
		{
			uint num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = UZwkY82drfNW54CBWLq(permission);
					num = 19;
					if (true)
					{
						continue;
					}
					break;
				case 11:
					if (num2 != 1807143726)
					{
						num = 15;
						if (nk5kjD2Up95G4GshuWs())
						{
							continue;
						}
						goto case 13;
					}
					if (!(permission == kgbOBx7BanbFa22Hp9.ol99ukmDA(15884)))
					{
						num = 5;
						if (nk5kjD2Up95G4GshuWs())
						{
							continue;
						}
						goto case 12;
					}
					return kgbOBx7BanbFa22Hp9.ol99ukmDA(16066);
				case 13:
					if (num2 != 1996865873)
					{
						num = 20;
						continue;
					}
					if (!MqlZye2qCfON8xx8hvD(permission, YXGQXB2iNGjpBEbpnRy(15768)))
					{
						num = 18;
						continue;
					}
					goto IL_034c;
				case 20:
					if (num2 != 2376030657u || !MqlZye2qCfON8xx8hvD(permission, YXGQXB2iNGjpBEbpnRy(15820)))
					{
						break;
					}
					return (string)YXGQXB2iNGjpBEbpnRy(16022);
				case 1:
					if (num2 == 1002304387)
					{
						if (!MqlZye2qCfON8xx8hvD(permission, YXGQXB2iNGjpBEbpnRy(15676)))
						{
							break;
						}
						goto IL_0336;
					}
					num = 6;
					continue;
				case 0:
					if (num2 != 1573836839)
					{
						goto case 11;
					}
					if (!MqlZye2qCfON8xx8hvD(permission, YXGQXB2iNGjpBEbpnRy(15796)))
					{
						break;
					}
					goto IL_034c;
				default:
					num = 11;
					if (true)
					{
						continue;
					}
					goto case 6;
				case 6:
					if (num2 != 1230018113)
					{
						num = 8;
						continue;
					}
					if (!MqlZye2qCfON8xx8hvD(permission, kgbOBx7BanbFa22Hp9.ol99ukmDA(15740)))
					{
						break;
					}
					return (string)YXGQXB2iNGjpBEbpnRy(15984);
				case 12:
					if (num2 == 54720604)
					{
						if (!(permission == (string)YXGQXB2iNGjpBEbpnRy(15656)))
						{
							break;
						}
						return (string)YXGQXB2iNGjpBEbpnRy(15950);
					}
					num = 9;
					if (nk5kjD2Up95G4GshuWs())
					{
						continue;
					}
					goto case 2;
				case 2:
					if (num2 > 141945333)
					{
						if (num2 == 931978502)
						{
							if (MqlZye2qCfON8xx8hvD(permission, YXGQXB2iNGjpBEbpnRy(15920)))
							{
								return (string)YXGQXB2iNGjpBEbpnRy(16066);
							}
							num = 21;
						}
						else
						{
							num = 1;
						}
					}
					else
					{
						num = 12;
					}
					continue;
				case 9:
					if (num2 == 141945333)
					{
						if (!MqlZye2qCfON8xx8hvD(permission, kgbOBx7BanbFa22Hp9.ol99ukmDA(15706)))
						{
							_ = 0;
							num = ((!nk5kjD2Up95G4GshuWs()) ? 4 : 17);
							continue;
						}
						goto IL_0336;
					}
					num = 10;
					if (!GtvBmg2Tm2MMoRxQHpp())
					{
						continue;
					}
					goto case 19;
				case 19:
					if (num2 > 1230018113)
					{
						if (num2 > 1807143726)
						{
							if (num2 == 1809614588)
							{
								if (MqlZye2qCfON8xx8hvD(permission, kgbOBx7BanbFa22Hp9.ol99ukmDA(15848)))
								{
									return (string)YXGQXB2iNGjpBEbpnRy(16048);
								}
								num = 7;
							}
							else
							{
								num = 13;
							}
							continue;
						}
						num = 0;
						if (nk5kjD2Up95G4GshuWs())
						{
							continue;
						}
					}
					else
					{
						num = 2;
						if (true)
						{
							continue;
						}
					}
					break;
				case 4:
				case 5:
				case 7:
				case 8:
				case 10:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
				case 21:
					break;
					IL_034c:
					return (string)YXGQXB2iNGjpBEbpnRy(16006);
					IL_0336:
					return (string)YXGQXB2iNGjpBEbpnRy(15968);
				}
				break;
			}
		}
		return permission;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsPermissionDefinitions()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		iG410N2B9luEgkvprjZ();
		ArrayOfEveryPermission = new string[30]
		{
			kgbOBx7BanbFa22Hp9.ol99ukmDA(16084),
			(string)YXGQXB2iNGjpBEbpnRy(16094),
			(string)YXGQXB2iNGjpBEbpnRy(15968),
			(string)YXGQXB2iNGjpBEbpnRy(16102),
			(string)YXGQXB2iNGjpBEbpnRy(16122),
			(string)YXGQXB2iNGjpBEbpnRy(15656),
			(string)YXGQXB2iNGjpBEbpnRy(16006),
			kgbOBx7BanbFa22Hp9.ol99ukmDA(16138),
			(string)YXGQXB2iNGjpBEbpnRy(16154),
			(string)YXGQXB2iNGjpBEbpnRy(16178),
			kgbOBx7BanbFa22Hp9.ol99ukmDA(16202),
			(string)YXGQXB2iNGjpBEbpnRy(16220),
			(string)YXGQXB2iNGjpBEbpnRy(16248),
			(string)YXGQXB2iNGjpBEbpnRy(15984),
			(string)YXGQXB2iNGjpBEbpnRy(16272),
			(string)YXGQXB2iNGjpBEbpnRy(16296),
			(string)YXGQXB2iNGjpBEbpnRy(16316),
			(string)YXGQXB2iNGjpBEbpnRy(16022),
			(string)YXGQXB2iNGjpBEbpnRy(16334),
			(string)YXGQXB2iNGjpBEbpnRy(16362),
			kgbOBx7BanbFa22Hp9.ol99ukmDA(16372),
			(string)YXGQXB2iNGjpBEbpnRy(16048),
			(string)YXGQXB2iNGjpBEbpnRy(16398),
			kgbOBx7BanbFa22Hp9.ol99ukmDA(16066),
			(string)YXGQXB2iNGjpBEbpnRy(15950),
			kgbOBx7BanbFa22Hp9.ol99ukmDA(16428),
			kgbOBx7BanbFa22Hp9.ol99ukmDA(16448),
			(string)YXGQXB2iNGjpBEbpnRy(16458),
			(string)YXGQXB2iNGjpBEbpnRy(16498),
			(string)YXGQXB2iNGjpBEbpnRy(16522)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint UZwkY82drfNW54CBWLq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YXGQXB2iNGjpBEbpnRy(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MqlZye2qCfON8xx8hvD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nk5kjD2Up95G4GshuWs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GtvBmg2Tm2MMoRxQHpp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iG410N2B9luEgkvprjZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}
}
