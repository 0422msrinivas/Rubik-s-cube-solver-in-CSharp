
using System.Windows.Media.Media3D;

namespace UziRubiksCube
	{
	/// <summary>
	/// Rubik's cube block class
	/// </summary>
	public class Block3D : ModelVisual3D
		{
		/// <summary>
		/// Array of 6 block faces
		/// </summary>
		public BlockFace3D[] BlockFaceArray;

		/// <summary>
		/// Block X position
		/// </summary>
		public double OrigX;

		/// <summary>
		/// Block Y position
		/// </summary>
		public double OrigY;

		/// <summary>
		/// Block Z position
		/// </summary>
		public double OrigZ;

		/// <summary>
		/// Block constructor
		/// </summary>
		/// <param name="BlockNo">Block number (0 to 26)</param>
		public Block3D
				(
				int BlockNo
				)
			{
			// for the hidden center block there is no more initialization
			if (BlockNo == 13) return;

			// block origin
			OrigX = -Cube3D.HalfCubeWidth + (BlockNo % 3) * (Cube3D.BlockWidth + Cube3D.BlockSpacing);
			OrigY = -Cube3D.HalfCubeWidth + ((BlockNo / 3) % 3) * (Cube3D.BlockWidth + Cube3D.BlockSpacing);
			OrigZ = -Cube3D.HalfCubeWidth + (BlockNo / 9) * (Cube3D.BlockWidth + Cube3D.BlockSpacing);

			// array of the 6 faces of this block
			BlockFaceArray = new BlockFace3D[6];

			// loop for all 6 faces
			for (int FaceColor = 0; FaceColor < Cube.FaceColors; FaceColor++)
				{
				// create 6 faces for each block
				// translate block number and face to face number
				BlockFaceArray[FaceColor] = new BlockFace3D(this, Cube.BlockFace[BlockNo, FaceColor], FaceColor);
				}
			return;
			}
		}
	}
