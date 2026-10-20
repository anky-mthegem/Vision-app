using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class CellNameUpdate : ISnippetUpdate
{
	private readonly string wJ8K6RjstT;

	private readonly bool Ks4Kunt3Bi;

	private readonly string d8JKF5f7fs;

	private readonly bool gnUKX0IGEj;

	private CvsCellLocation fUkKoZeRml;

	private readonly bool H3aKS8byxr;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CellNameUpdate(string oldName, bool oldNameIsInternal, string newName, bool newNameIsInternal, bool isSupportSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00a4;
		IL_0037:
		wJ8K6RjstT = newName;
		num = 4;
		if (false)
		{
			goto IL_004a;
		}
		goto IL_00a4;
		IL_008b:
		gnUKX0IGEj = oldNameIsInternal;
		goto IL_0037;
		IL_004a:
		d8JKF5f7fs = oldName;
		num = 0;
		if (rfSK3MtlmcgqZqC1Yow())
		{
			goto IL_0061;
		}
		goto IL_00a4;
		IL_001a:
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		_ = 1;
		if (!rfSK3MtlmcgqZqC1Yow())
		{
			num = 8;
			if (false)
			{
				goto IL_0037;
			}
		}
		else
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_008b;
			}
		}
		goto IL_00a4;
		IL_00a4:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 7:
				goto IL_0037;
			case 2:
			case 6:
				goto IL_004a;
			case 5:
				goto IL_0061;
			case 1:
			case 8:
				yE8Ty6tgOqRLoeiTqga(this);
				goto IL_004a;
			case 0:
				goto IL_008b;
			default:
				num = 7;
				continue;
			case 4:
				Ks4Kunt3Bi = newNameIsInternal;
				num = 5;
				continue;
			case 9:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_0061:
		H3aKS8byxr = isSupportSnippet;
		num = 9;
		goto IL_00a4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CellNameUpdate(CvsCellLocation offset, string newName, bool newNameIsInternal, bool isSupportSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (!pd1Zt6tdvbVtlblqoe8())
		{
			goto IL_001e;
		}
		goto IL_0037;
		IL_00b1:
		Ks4Kunt3Bi = newNameIsInternal;
		goto IL_009f;
		IL_0037:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			default:
				num = 1;
				continue;
			case 7:
				Q6imNJtsM1myRSeNStA();
				num = 6;
				if (pd1Zt6tdvbVtlblqoe8())
				{
					continue;
				}
				goto case 6;
			case 6:
				yE8Ty6tgOqRLoeiTqga(this);
				pd1Zt6tdvbVtlblqoe8();
				num = (rfSK3MtlmcgqZqC1Yow() ? 3 : 4);
				continue;
			case 3:
			case 5:
				goto IL_009f;
			case 1:
				goto IL_00b1;
			case 2:
			case 4:
				fUkKoZeRml = offset;
				num = 0;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_009f:
		H3aKS8byxr = isSupportSnippet;
		num = 8;
		goto IL_0037;
		IL_001e:
		wJ8K6RjstT = newName;
		goto IL_00b1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CellNameUpdate MakeInternal(string name, bool isSupportSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CellNameUpdate(name, oldNameIsInternal: false, name, newNameIsInternal: true, isSupportSnippet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CellNameUpdate MakePublic(string name, bool isSupportSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CellNameUpdate(name, oldNameIsInternal: true, name, newNameIsInternal: false, isSupportSnippet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		rfSK3MtlmcgqZqC1Yow();
		int num;
		if (pd1Zt6tdvbVtlblqoe8())
		{
			num = 11;
		}
		else
		{
			num = 6;
			if (rfSK3MtlmcgqZqC1Yow())
			{
				goto IL_00f4;
			}
		}
		goto IL_006c;
		IL_0111:
		string text2;
		string text = text2;
		CvsCellLocation location = default;
		string text3;
		string snippetName = default;
		if (d8JKF5f7fs == null)
		{
			location = DitnMKtBJg81gCcMPms(originalSnippet);
			num = 5;
			if (rfSK3MtlmcgqZqC1Yow())
			{
				goto IL_00d5;
			}
		}
		else
		{
			if (!H3aKS8byxr)
			{
				text3 = EzSnippet.AssembleFullCellName(snippetName, d8JKF5f7fs, gnUKX0IGEj);
				goto IL_01aa;
			}
			num = 2;
		}
		goto IL_006c;
		IL_00d5:
		PasteBuffer pasteBuffer = default;
		PasteBufferCell pasteBufferCell = (PasteBufferCell)IUIQHJtP1SB3v3S8vvT(pasteBuffer, text);
		goto IL_00b3;
		IL_00ff:
		text2 = EzSnippet.AssembleFullCellName(snippetName, wJ8K6RjstT, Ks4Kunt3Bi);
		goto IL_0111;
		IL_01aa:
		string text4 = text3;
		pasteBufferCell = (PasteBufferCell)IUIQHJtP1SB3v3S8vvT(pasteBuffer, text4);
		num = 4;
		goto IL_006c;
		IL_00b3:
		IUGKGLtZ2FqBwnROLUG(pasteBufferCell, text);
		return pasteBuffer;
		IL_006c:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 11:
				pasteBuffer = (PasteBuffer)U6mhQEtvw2odycQQAoj(originalSnippet);
				num = 8;
				continue;
			case 12:
				IUGKGLtZ2FqBwnROLUG(skHm7ltbJXgj2vgJE2r(pasteBuffer, location), text);
				num = 13;
				continue;
			case 4:
				if (pasteBufferCell != null)
				{
					break;
				}
				goto IL_00d5;
			default:
				num = 3;
				continue;
			case 6:
			case 7:
				break;
			case 3:
				goto IL_00d5;
			case 1:
				goto IL_00f4;
			case 5:
				location.Row += fUkKoZeRml.Row;
				num = 9;
				continue;
			case 10:
				goto IL_0155;
			case 9:
				location.Column += fUkKoZeRml.Column;
				num = 12;
				continue;
			case 2:
				goto IL_018d;
			case 8:
				snippetName = (string)D4p7g1trx60lM3YadYH(pasteBuffer);
				num = 10;
				continue;
			case 13:
				return pasteBuffer;
			}
			break;
			IL_0155:
			if (H3aKS8byxr)
			{
				num = 1;
				continue;
			}
			goto IL_00ff;
		}
		goto IL_00b3;
		IL_00f4:
		text2 = wJ8K6RjstT;
		goto IL_0111;
		IL_018d:
		text3 = d8JKF5f7fs;
		goto IL_01aa;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yE8Ty6tgOqRLoeiTqga(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pd1Zt6tdvbVtlblqoe8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rfSK3MtlmcgqZqC1Yow()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q6imNJtsM1myRSeNStA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U6mhQEtvw2odycQQAoj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D4p7g1trx60lM3YadYH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IUIQHJtP1SB3v3S8vvT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithName((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IUGKGLtZ2FqBwnROLUG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation DitnMKtBJg81gCcMPms(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object skHm7ltbJXgj2vgJE2r(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellAt(location);
	}
}
