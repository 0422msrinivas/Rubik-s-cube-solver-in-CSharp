namespace UziRubiksCube
{
/// <summary>
/// Corner block
/// </summary>
public class CornerBlock
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
	/// Third face number 0-47
	/// </summary>
	public int FaceNo3;

	/// <summary>
	/// First face color 0-5
	/// </summary>
	public int FaceColor1;

	/// <summary>
	/// Second face color 0-5
	/// </summary>
	public int FaceColor2;

	/// <summary>
	/// Third face color 0-5
	/// </summary>
	public int FaceColor3;

	/// <summary>
	/// Corner block constructor
	/// </summary>
	/// <param name="FaceNo1">Face 1</param>
	/// <param name="FaceNo2">Face 2</param>
	/// <param name="FaceNo3">Face 3</param>
	public CornerBlock
			(
			int FaceNo1,
			int FaceNo2,
			int FaceNo3
			)
		{
		this.FaceNo1 = FaceNo1;
		this.FaceNo2 = FaceNo2;
		this.FaceNo3 = FaceNo3;
		FaceColor1 = FaceNo1 / Cube.FaceNoToColor;
		FaceColor2 = FaceNo2 / Cube.FaceNoToColor;
		FaceColor3 = FaceNo3 / Cube.FaceNoToColor;
		return;
		}
	}
}
