namespace Packt.Shared
{
	[System.Flags]
	public enum WondersOfTheAncientWorld : byte
	{
		None	= 0b_0000_0000,
		Pyramid = 0b_0000_0001,
		Babylon = 0b_0000_0010,
		Zeus	= 0b_0000_0100,
		Artemis = 0b_0000_1000,
		Mausoleum = 0b_0001_0000,
		Rhodes = 0b_0010_0000,
		Alexandria = 0b_0100_0000
	}
}
