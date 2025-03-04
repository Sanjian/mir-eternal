﻿using System;

namespace GameServer.Networking
{
	
	[PacketInfoAttribute(来源 = PacketSource.服务器, 编号 = 259, 长度 = 31, 注释 = "DecompositionItemResponsePacket")]
	public sealed class DecompositionItemResponsePacket : GamePacket
	{
		
		public DecompositionItemResponsePacket()
		{
			
			
		}

		
		[WrappingFieldAttribute(SubScript = 2, Length = 1)]
		public byte 分解数量;

		
		[WrappingFieldAttribute(SubScript = 3, Length = 4)]
		public int 分解物品;

		
		[WrappingFieldAttribute(SubScript = 7, Length = 4)]
		public int 分解物一;

		
		[WrappingFieldAttribute(SubScript = 11, Length = 4)]
		public int 分解物二;

		
		[WrappingFieldAttribute(SubScript = 15, Length = 4)]
		public int 分解物三;

		
		[WrappingFieldAttribute(SubScript = 19, Length = 4)]
		public int 物品数一;

		
		[WrappingFieldAttribute(SubScript = 23, Length = 4)]
		public int 物品数二;

		
		[WrappingFieldAttribute(SubScript = 27, Length = 4)]
		public int 物品数三;
	}
}
