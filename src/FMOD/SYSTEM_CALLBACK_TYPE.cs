using System;

namespace FMOD
{
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		DEVICELISTCHANGED = 1u,
		DEVICELOST = 2u,
		MEMORYALLOCATIONFAILED = 4u,
		THREADCREATED = 8u,
		BADDSPCONNECTION = 16u,
		PREMIX = 32u,
		POSTMIX = 64u,
		ERROR = 128u,
		MIDMIX = 256u,
		THREADDESTROYED = 512u,
		PREUPDATE = 1024u,
		POSTUPDATE = 2048u,
		RECORDLISTCHANGED = 4096u,
		ALL = 4294967295u
	}
}
