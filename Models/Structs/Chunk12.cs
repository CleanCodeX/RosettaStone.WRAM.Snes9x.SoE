using System.Diagnostics;
using System.Runtime.InteropServices;
using RosettaStone.Savestate.Snes9x.SoE.Extensions;
using RosettaStone.Savestate.Snes9x.SoE.Constants;

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk12
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Chunk12)]
		public byte[] Data;

		public char[] AsChars => Data.GetChars();
		
		public override string ToString() => new(AsChars);
	}
}