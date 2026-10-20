using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public struct CvsCellRange : IEnumerable<CvsCellLocation>, IEnumerable, IEquatable<CvsCellRange>
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__56 : IEnumerator<CvsCellLocation>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private CvsCellLocation _003C_003E2__current;

		public CvsCellRange _003C_003E4__this;

		private int _003Crow_003E5__2;

		private int _003Ccolumn_003E5__3;

		CvsCellLocation IEnumerator<CvsCellLocation>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__56(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (wGxMlxsDh68ACMVyLLIp())
			{
				num = 1;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_006b;
				}
			}
			goto IL_003c;
			IL_003c:
			while (true)
			{
				switch (num)
				{
				case 4:
					base._002Ector();
					break;
				case 0:
				case 1:
					goto IL_007c;
				case 5:
					return;
				}
				break;
				IL_007c:
				kad02psD9w3uQ0XPK1ZA();
				num = 4;
			}
			goto IL_006b;
			IL_006b:
			this._003C_003E1__state = _003C_003E1__state;
			num = 5;
			goto IL_003c;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 13;
			if (0 == 0)
			{
				goto IL_0042;
			}
			goto IL_0091;
			IL_0130:
			int num2 = _003C_003E1__state;
			num = 4;
			goto IL_0042;
			IL_00b1:
			int num3 = default;
			if (_003Ccolumn_003E5__3 > _003C_003E4__this.LastColumn)
			{
				num3 = _003Crow_003E5__2;
				num = 0;
			}
			else
			{
				_003C_003E2__current = new CvsCellLocation(_003Crow_003E5__2, _003Ccolumn_003E5__3);
				_ = 1;
				if (DhTvoqsDLuwoOyDF5XNg())
				{
					num = 5;
					if (DhTvoqsDLuwoOyDF5XNg())
					{
						goto IL_0130;
					}
				}
				else
				{
					num = 9;
				}
			}
			goto IL_0042;
			IL_0042:
			while (true)
			{
				switch (num)
				{
				default:
					num = 12;
					continue;
				case 6:
				case 14:
					break;
				case 5:
				case 10:
				case 12:
					goto IL_00b1;
				case 2:
					return false;
				case 4:
					do
					{
						if (num2 == 0)
						{
							_003C_003E1__state = -1;
							num = 7;
							continue;
						}
						num = 3;
						break;
					}
					while (!wGxMlxsDh68ACMVyLLIp());
					continue;
				case 1:
					return true;
				case 13:
					goto IL_0130;
				case 3:
					goto IL_0141;
				case 11:
					return false;
				case 7:
					goto IL_01a1;
				case 8:
				case 9:
					_003C_003E1__state = 1;
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
					_003Crow_003E5__2 = num3 + 1;
					num = 14;
					continue;
				case 15:
					return false;
				}
				break;
				IL_01a1:
				if (_003C_003E4__this.IsValid)
				{
					_003Crow_003E5__2 = _003C_003E4__this.Row;
					num = 6;
				}
				else
				{
					num = 11;
				}
				continue;
				IL_0141:
				if (num2 == 1)
				{
					_003C_003E1__state = -1;
					num3 = _003Ccolumn_003E5__3++;
					goto IL_00b1;
				}
				num = 2;
			}
			goto IL_0091;
			IL_0091:
			if (_003Crow_003E5__2 <= _003C_003E4__this.LastRow)
			{
				_003Ccolumn_003E5__3 = _003C_003E4__this.Column;
				goto IL_00b1;
			}
			num = 15;
			goto IL_0042;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotSupportedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kad02psD9w3uQ0XPK1ZA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wGxMlxsDh68ACMVyLLIp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DhTvoqsDLuwoOyDF5XNg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellLocation U1HpOh6iWk;

	private int lQoppET8Kg;

	private int DnIphvecqk;

	public static readonly CvsCellRange Empty;

	public static readonly CvsCellRange Invalid;

	public int Row
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U1HpOh6iWk.Row;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			U1HpOh6iWk.Row = value;
		}
	}

	public int Column
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U1HpOh6iWk.Column;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			U1HpOh6iWk.Column = value;
		}
	}

	public int LastRow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U1HpOh6iWk.Row + lQoppET8Kg - 1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lQoppET8Kg = value - U1HpOh6iWk.Row + 1;
		}
	}

	public int LastColumn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U1HpOh6iWk.Column + DnIphvecqk - 1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DnIphvecqk = value - U1HpOh6iWk.Column + 1;
		}
	}

	public CvsCellLocation LastLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsCellLocation(LastRow, LastColumn);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LastRow = value.Row;
			LastColumn = value.Column;
		}
	}

	public int Rows
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lQoppET8Kg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lQoppET8Kg = value;
		}
	}

	public int Columns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DnIphvecqk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DnIphvecqk = value;
		}
	}

	public CvsCellLocation Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U1HpOh6iWk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			U1HpOh6iWk = value;
		}
	}

	public Size Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new Size(DnIphvecqk, lQoppET8Kg);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DnIphvecqk = value.Width;
			lQoppET8Kg = value.Height;
		}
	}

	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (lQoppET8Kg != 0)
			{
				return DnIphvecqk == 0;
			}
			return true;
		}
	}

	public bool IsValid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (U1HpOh6iWk.IsValid && lQoppET8Kg >= 0)
			{
				return DnIphvecqk >= 0;
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellRange(string range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PGLnAEBDxWm15kMGwIh();
		int num = ((!Jpm7rpBAooGgh527Rsf()) ? 7 : 5);
		CvsCellLocation cvsCellLocation = default;
		string[] array = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				cvsCellLocation = new CvsCellLocation(array[1]);
				num = 2;
				break;
			case 0:
			case 5:
				LYrnGoBUBCms1qYhBaZ();
				goto case 1;
			case 1:
			case 7:
				array = (string[])xjFWbkBTLrZ64qhA4C6(range, new char[1] { ':' });
				if (array.Length == 1)
				{
					num = 8;
					break;
				}
				U1HpOh6iWk = new CvsCellLocation(array[0]);
				num = 9;
				break;
			case 2:
				DnIphvecqk = cvsCellLocation.Column - U1HpOh6iWk.Column + 1;
				num = 4;
				break;
			case 8:
				U1HpOh6iWk = new CvsCellLocation(array[0]);
				num = 6;
				if (PGLnAEBDxWm15kMGwIh())
				{
					return;
				}
				break;
			case 3:
				return;
			case 4:
				lQoppET8Kg = cvsCellLocation.Row - U1HpOh6iWk.Row + 1;
				num = 11;
				break;
			case 6:
				DnIphvecqk = 1;
				num = 10;
				break;
			case 10:
				lQoppET8Kg = 1;
				return;
			default:
				num = 3;
				if (false)
				{
					return;
				}
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellRange(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		do
		{
			IL_0031:
			switch (num)
			{
			case 2:
			case 4:
				DnIphvecqk = 1;
				break;
			case 1:
				do
				{
					U1HpOh6iWk = location;
					Jpm7rpBAooGgh527Rsf();
					if (PGLnAEBDxWm15kMGwIh())
					{
						num = 0;
						continue;
					}
					num = 4;
					break;
				}
				while (1 == 0);
				goto IL_0031;
			case 5:
				LYrnGoBUBCms1qYhBaZ();
				num = 1;
				goto IL_0031;
			case 6:
				return;
			}
			lQoppET8Kg = 1;
			num = 6;
		}
		while (Jpm7rpBAooGgh527Rsf());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellRange(CvsCellLocation location, Size size)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PGLnAEBDxWm15kMGwIh();
		int num;
		if (Jpm7rpBAooGgh527Rsf())
		{
			num = 3;
			if (PGLnAEBDxWm15kMGwIh())
			{
			}
		}
		else
		{
			num = 5;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				DnIphvecqk = size.Width;
				break;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				LYrnGoBUBCms1qYhBaZ();
				goto case 1;
			case 1:
			case 5:
				U1HpOh6iWk = location;
				num = 4;
				continue;
			case 2:
				break;
			case 6:
				return;
			}
			lQoppET8Kg = size.Height;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellRange(CvsCellLocation location, CvsCellLocation lastLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				lQoppET8Kg = lastLocation.Row - location.Row + 1;
				num = 6;
				break;
			case 2:
			case 5:
				DnIphvecqk = lastLocation.Column - location.Column + 1;
				goto default;
			case 1:
				U1HpOh6iWk = location;
				PGLnAEBDxWm15kMGwIh();
				if (!Jpm7rpBAooGgh527Rsf())
				{
					num = 0;
					if (PGLnAEBDxWm15kMGwIh())
					{
					}
				}
				else
				{
					num = 5;
				}
				break;
			case 4:
				LYrnGoBUBCms1qYhBaZ();
				num = 1;
				if (!Jpm7rpBAooGgh527Rsf())
				{
					return;
				}
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellRange(int row, char column, int rows, int columns)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Jpm7rpBAooGgh527Rsf();
		int num;
		if (!PGLnAEBDxWm15kMGwIh())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0043;
		IL_002a:
		lQoppET8Kg = rows;
		goto IL_006e;
		IL_0043:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				num = 2;
				continue;
			case 2:
				goto IL_006e;
			case 0:
			case 4:
				goto IL_0086;
			case 1:
			case 3:
				goto IL_009b;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_006e:
		DnIphvecqk = columns;
		num = 6;
		if (Jpm7rpBAooGgh527Rsf())
		{
			goto IL_0043;
		}
		goto IL_0086;
		IL_009b:
		U1HpOh6iWk = new CvsCellLocation(row, column.ToString());
		num = 5;
		goto IL_0043;
		IL_0086:
		LYrnGoBUBCms1qYhBaZ();
		goto IL_009b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellRange(int row, int column, int rows, int columns)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Jpm7rpBAooGgh527Rsf();
		int num = (PGLnAEBDxWm15kMGwIh() ? 4 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				U1HpOh6iWk = new CvsCellLocation(row, column);
				num = 3;
				continue;
			case 3:
				lQoppET8Kg = rows;
				break;
			default:
				num = 5;
				if (!PGLnAEBDxWm15kMGwIh())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				LYrnGoBUBCms1qYhBaZ();
				goto case 1;
			case 5:
				break;
			case 6:
				return;
			}
			DnIphvecqk = columns;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellRange TryParse(string range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsCellRange empty = default;
		CvsCellLocation cvsCellLocation = default;
		CvsCellLocation u1HpOh6iWk = default;
		string[] array = default;
		CvsCellLocation u1HpOh6iWk2 = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				empty.DnIphvecqk = cvsCellLocation.Column - u1HpOh6iWk.Column + 1;
				goto case 0;
			case 13:
				do
				{
					u1HpOh6iWk = hBCSeCBdJbw7CGIiEJP(array[0]);
					_ = 0;
					if (!Jpm7rpBAooGgh527Rsf())
					{
						num = 0;
						continue;
					}
					num = 1;
					break;
				}
				while (false);
				continue;
			case 9:
				if (array.Length == 1)
				{
					u1HpOh6iWk2 = hBCSeCBdJbw7CGIiEJP(array[0]);
					num = 2;
					if (PGLnAEBDxWm15kMGwIh())
					{
					}
					continue;
				}
				if (array.Length != 2)
				{
					break;
				}
				goto case 13;
			case 3:
				empty = Empty;
				num = 4;
				continue;
			case 0:
			case 12:
				empty.lQoppET8Kg = cvsCellLocation.Row - u1HpOh6iWk.Row + 1;
				num = 15;
				continue;
			case 7:
				empty.U1HpOh6iWk = u1HpOh6iWk2;
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				break;
			default:
				num = 13;
				continue;
			case 5:
				if (cvsCellLocation.IsValid)
				{
					num = 14;
					continue;
				}
				break;
			case 2:
				if (u1HpOh6iWk2.IsValid)
				{
					num = 7;
					continue;
				}
				break;
			case 10:
				empty.DnIphvecqk = 1;
				empty.lQoppET8Kg = 1;
				num = 6;
				continue;
			case 14:
				empty.U1HpOh6iWk = u1HpOh6iWk;
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 8:
				cvsCellLocation = hBCSeCBdJbw7CGIiEJP(array[1]);
				if (!u1HpOh6iWk.IsValid)
				{
					break;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				array = range.Split(':');
				num = 9;
				if (Jpm7rpBAooGgh527Rsf())
				{
					continue;
				}
				break;
			case 6:
			case 15:
				break;
			}
			break;
		}
		return empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (obj is CvsCellRange)
		{
			return Equals((CvsCellRange)obj);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (PMKxNyBi19qn0eOeuDM(Location, range.Location) && Columns == range.Columns)
		{
			return Rows == range.Rows;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(CvsCellRange left, CvsCellRange right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left.Equals(right);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(CvsCellRange left, CvsCellRange right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !left.Equals(right);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Location.GetHashCode() * 167 + LastLocation.GetHashCode() * 739;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ToString(absoluteRow: false, absoluteColumn: false, absoluteLastRow: false, absoluteLastColumn: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToString(bool absoluteRow, bool absoluteColumn, bool absoluteLastRow, bool absoluteLastColumn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		string text = default;
		string text2 = default;
		CvsCellLocation cvsCellLocation = default;
		string result = default;
		while (true)
		{
			switch (num)
			{
			case 12:
				if (swb2MVBqHhCx8Dcyvwk(text) > 0)
				{
					goto case 8;
				}
				goto IL_00e7;
			case 8:
			case 9:
				if (swb2MVBqHhCx8Dcyvwk(text2) > 0)
				{
					num = 4;
					continue;
				}
				goto IL_00e7;
			case 10:
				cvsCellLocation = Location;
				num = 11;
				continue;
			case 0:
				text2 = cvsCellLocation.ToString(absoluteLastRow, absoluteLastColumn);
				num = 12;
				continue;
			case 3:
				if (Rows == 1)
				{
					_ = 0;
					num = (Jpm7rpBAooGgh527Rsf() ? 5 : 9);
					continue;
				}
				goto IL_00d1;
			case 4:
				result = text + (string)ov0w6PBBxtB9SPcEKdC(5954) + text2;
				num = 7;
				continue;
			case 2:
				text = cvsCellLocation.ToString(absoluteRow, absoluteColumn);
				num = 6;
				continue;
			case 11:
				result = cvsCellLocation.ToString(absoluteRow, absoluteColumn);
				break;
			case 6:
				cvsCellLocation = LastLocation;
				goto case 0;
			default:
				num = 0;
				continue;
			case 1:
			case 5:
				if (Columns == 1)
				{
					num = 10;
					continue;
				}
				goto IL_00d1;
			case 7:
			case 13:
				break;
				IL_00e7:
				result = string.Empty;
				num = 13;
				continue;
				IL_00d1:
				cvsCellLocation = Location;
				num = 2;
				continue;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ContainsRow(location.Row))
		{
			return ContainsColumn(location.Column);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (range.IsEmpty)
		{
			return Contains(range.Location);
		}
		if (Contains(range.Location))
		{
			return Contains(range.LastLocation);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(int row, int column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ContainsRow(row))
		{
			return ContainsColumn(column);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsRow(int row)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Row <= row)
		{
			return row <= LastRow;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsColumn(int column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Column <= column)
		{
			return column <= LastColumn;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation GetNearest(CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (loc.Row <= LastRow)
				{
					goto case 0;
				}
				goto default;
			case 8:
				if (loc.Column > LastColumn)
				{
					num = 3;
					continue;
				}
				goto case 2;
			case 0:
				if (loc.Row < Row)
				{
					num = 1;
					continue;
				}
				break;
			default:
				loc.Row = LastRow;
				num = 0;
				continue;
			case 1:
				loc.Row = Row;
				num = 10;
				continue;
			case 2:
			case 6:
				if (loc.Column >= Column)
				{
					goto case 4;
				}
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				loc.Column = LastColumn;
				_ = 0;
				num = (Jpm7rpBAooGgh527Rsf() ? 6 : 9);
				continue;
			case 7:
				loc.Column = Column;
				num = 4;
				continue;
			case 10:
				break;
			}
			break;
		}
		return loc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__56))]
	public IEnumerator<CvsCellLocation> GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetEnumerator_003Ed__56(0)
		{
			_003C_003E4__this = this
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellRange Union(CvsCellRange a, CvsCellRange b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		CvsCellRange result = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				if (b.IsEmpty)
				{
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 6;
				}
				goto IL_007a;
			case 6:
				result = Empty;
				_ = 0;
				num = ((!Jpm7rpBAooGgh527Rsf()) ? 8 : 0);
				continue;
			case 2:
				result = a;
				num = 7;
				continue;
			case 4:
			case 8:
				result = b;
				break;
			default:
				num = 1;
				continue;
			case 5:
				if (a.IsEmpty)
				{
					num = 9;
					continue;
				}
				goto IL_007a;
			case 0:
			case 1:
			case 3:
			case 7:
			case 10:
				break;
				IL_007a:
				if (a.IsEmpty)
				{
					goto case 4;
				}
				if (!b.IsEmpty)
				{
					result = Union(RuPnO1Bjtr8lbhHjsOb(a, b.Location), b.LastLocation);
					num = 10;
					continue;
				}
				num = 2;
				if (true)
				{
					continue;
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellRange Union(CvsCellRange range, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		CvsCellRange result = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				result.Column = LVaovPBckwwXgbPPEhi(range.Column, location.Column);
				goto case 0;
			case 3:
				result = new CvsCellRange(location);
				PGLnAEBDxWm15kMGwIh();
				num = (Jpm7rpBAooGgh527Rsf() ? 4 : 0);
				break;
			case 6:
				if (!range.IsEmpty)
				{
					result = default;
					num = 7;
				}
				else
				{
					num = 3;
				}
				break;
			case 2:
			case 4:
			case 7:
				result.Row = LVaovPBckwwXgbPPEhi(range.Row, location.Row);
				goto case 1;
			default:
				num = 1;
				break;
			case 8:
				result.Columns = Math.Max(range.LastColumn, location.Column) - result.Column + 1;
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				result.Rows = Math.Max(range.LastRow, location.Row) - result.Row + 1;
				num = 8;
				break;
			case 9:
				return result;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellRange Intersect(CvsCellRange a, CvsCellRange b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Jpm7rpBAooGgh527Rsf();
		int num = (PGLnAEBDxWm15kMGwIh() ? 1 : 5);
		int num4 = default;
		int num2 = default;
		int num3 = default;
		int num5 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (num4 >= num2)
				{
					num = 8;
					continue;
				}
				break;
			case 6:
				num4 = LVaovPBckwwXgbPPEhi(a.LastRow, b.LastRow);
				goto default;
			case 7:
				num2 = yPKpSIB2cfe0TBKAuQs(a.Row, b.Row);
				num = 6;
				continue;
			case 0:
			case 5:
				num3 = yPKpSIB2cfe0TBKAuQs(a.Column, b.Column);
				num = 2;
				continue;
			case 2:
				num5 = Math.Min(a.LastColumn, b.LastColumn);
				num = 7;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				if (num5 >= num3)
				{
					num = 3;
					if (PGLnAEBDxWm15kMGwIh())
					{
					}
					continue;
				}
				break;
			case 8:
				return new CvsCellRange(num2, num3, num4 - num2 + 1, num5 - num3 + 1);
			}
			break;
		}
		return Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellRange Normalize(CvsCellRange value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (!Jpm7rpBAooGgh527Rsf())
		{
			goto IL_001e;
		}
		goto IL_00b8;
		IL_001e:
		if (value.lQoppET8Kg < 0)
		{
			goto IL_005f;
		}
		_ = 1;
		num = (PGLnAEBDxWm15kMGwIh() ? 6 : 0);
		goto IL_00b8;
		IL_005f:
		int column = value.U1HpOh6iWk.Column;
		num = 1;
		goto IL_00b8;
		IL_00b8:
		int row = default;
		int lastRow = default;
		int lastColumn = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 3:
				row = value.U1HpOh6iWk.Row;
				goto case 5;
			case 0:
			case 2:
				return value;
			case 7:
				goto IL_0076;
			case 5:
			case 6:
				lastRow = value.LastRow;
				num = 8;
				continue;
			case 1:
				lastColumn = value.LastColumn;
				goto case 3;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				return new CvsCellRange(LVaovPBckwwXgbPPEhi(row, lastRow), LVaovPBckwwXgbPPEhi(column, lastColumn), wMMeqhBWUUk1wcUN7ZS(row - lastRow) + 1, wMMeqhBWUUk1wcUN7ZS(column - lastColumn) + 1);
			}
			break;
			IL_0076:
			if (value.DnIphvecqk >= 0)
			{
				num = 4;
				continue;
			}
			goto IL_005f;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellRange[] Subtract(CvsCellRange a, CvsCellRange b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PGLnAEBDxWm15kMGwIh();
		int num;
		if (Jpm7rpBAooGgh527Rsf())
		{
			num = 9;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_0166;
			}
		}
		goto IL_01ee;
		IL_0128:
		CvsCellRange left = default;
		if (left.Column <= a.Column)
		{
			goto IL_00cd;
		}
		num = 11;
		if (PGLnAEBDxWm15kMGwIh())
		{
			goto IL_014b;
		}
		goto IL_01ee;
		IL_0049:
		if (a.LastRow <= left.LastRow)
		{
			goto IL_009c;
		}
		CvsCellRange[] array = default;
		int num2 = default;
		array[num2++] = new CvsCellRange(left.LastRow + 1, a.Column, a.LastRow - left.LastRow, a.Columns);
		num = 13;
		goto IL_01ee;
		IL_023d:
		CvsCellRange[] array2 = default;
		pxdZt0BC4JPAxeUh6ft(array, 0, array2, 0, num2);
		num = 15;
		goto IL_01ee;
		IL_00cd:
		if (a.LastColumn <= left.LastColumn)
		{
			goto IL_0049;
		}
		num = 4;
		goto IL_01ee;
		IL_014b:
		return array;
		IL_002a:
		num2 = 0;
		if (left.Row <= a.Row)
		{
			goto IL_0128;
		}
		num = 8;
		goto IL_01ee;
		IL_009c:
		if (num2 == 4)
		{
			num = 3;
			goto IL_01ee;
		}
		array2 = new CvsCellRange[num2];
		goto IL_023d;
		IL_01ee:
		while (true)
		{
			switch (num)
			{
			case 14:
				break;
			case 7:
				goto IL_0049;
			case 13:
				goto IL_009c;
			case 10:
				goto IL_00ad;
			case 6:
				goto IL_00cd;
			case 8:
				array[num2++] = new CvsCellRange(a.Row, a.Column, left.Row - a.Row, a.Columns);
				num = 2;
				continue;
			case 2:
				goto IL_0128;
			case 3:
				goto IL_014b;
			case 1:
				goto IL_0166;
			case 0:
			case 9:
				left = hat6GbB7me0GhWxm533(a, b);
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 11;
			case 11:
				array[num2++] = new CvsCellRange(left.Row, a.Column, left.Rows, left.Column - a.Column);
				goto IL_00cd;
			default:
				num = 6;
				continue;
			case 5:
			case 12:
				goto IL_023d;
			case 4:
				array[num2++] = new CvsCellRange(left.Row, left.LastColumn + 1, left.Rows, a.LastColumn - left.LastColumn);
				num = 7;
				continue;
			case 15:
				return array2;
			}
			break;
			IL_00ad:
			if (left.IsEmpty)
			{
				num = 1;
				if (PGLnAEBDxWm15kMGwIh())
				{
				}
				continue;
			}
			if (mQVU2yBtoP7xCswBNmt(left, a))
			{
				return null;
			}
			array = new CvsCellRange[4];
			num = 14;
		}
		goto IL_002a;
		IL_0166:
		return new CvsCellRange[1] { a };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCellRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 4:
				LYrnGoBUBCms1qYhBaZ();
				_ = 0;
				if (Jpm7rpBAooGgh527Rsf())
				{
					num = 3;
					continue;
				}
				num = 0;
				if (PGLnAEBDxWm15kMGwIh())
				{
				}
				continue;
			case 1:
			case 3:
				Empty = default;
				break;
			case 5:
				return;
			}
			Invalid = new CvsCellRange(int.MinValue, int.MinValue, 0, 0);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LYrnGoBUBCms1qYhBaZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xjFWbkBTLrZ64qhA4C6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Jpm7rpBAooGgh527Rsf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PGLnAEBDxWm15kMGwIh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation hBCSeCBdJbw7CGIiEJP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PMKxNyBi19qn0eOeuDM(CvsCellLocation left, CvsCellLocation right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left == right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int swb2MVBqHhCx8Dcyvwk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ov0w6PBBxtB9SPcEKdC(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange RuPnO1Bjtr8lbhHjsOb(CvsCellRange range, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Union(range, location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LVaovPBckwwXgbPPEhi(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yPKpSIB2cfe0TBKAuQs(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wMMeqhBWUUk1wcUN7ZS(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Abs(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange hat6GbB7me0GhWxm533(CvsCellRange a, CvsCellRange b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Intersect(a, b);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mQVU2yBtoP7xCswBNmt(CvsCellRange left, CvsCellRange right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left == right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pxdZt0BC4JPAxeUh6ft(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
	}
}
