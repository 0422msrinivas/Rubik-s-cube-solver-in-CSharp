
using System.Windows.Media.Media3D;

namespace UziRubiksCube
	{
	/// <summary>
	/// Wrapper class to save block face
	/// </summary>
	public class ModelVisual3DCube : ModelVisual3D
		{
		/// <summary>
		/// Block face
		/// </summary>
		public BlockFace3D BlockFace;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="BlockFace">Block face</param>
		/// <param name="GeometryModel">Geometry model</param>
		public ModelVisual3DCube
				(
				BlockFace3D BlockFace,
				GeometryModel3D GeometryModel
				)
			{
			this.BlockFace = BlockFace;
			Content = GeometryModel;
			return;
			}
		}
	}
