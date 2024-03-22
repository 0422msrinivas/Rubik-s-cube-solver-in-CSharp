namespace UziRubiksCube
	{
	/// <summary>
	/// Edge block
	/// </summary>
	public class EdgeBlock
		{
		/// <summary>
		/// First face number 0-47
		/// </summary>
		public int FaceNo1;

		/// <summary>
		/// Second face number 0-47
		/// </summary>
		public int FaceNo2;

		/// <summary>
		/// First face color 0-5
		/// </summary>
		public int FaceColor1;

		/// <summary>
		/// Second face color 0-5
		/// </summary>
		public int FaceColor2;

		/// <summary>
		/// Edge block constructor
		/// </summary>
		/// <param name="FaceNo1">Face 1</param>
		/// <param name="FaceNo2">Face 2</param>
		public EdgeBlock
				(
				int FaceNo1,
				int FaceNo2
				)
			{
			this.FaceNo1 = FaceNo1;
			this.FaceNo2 = FaceNo2;
			FaceColor1 = FaceNo1 / Cube.FaceNoToColor;
			FaceColor2 = FaceNo2 / Cube.FaceNoToColor;
			return;
			}
		}
	}
