
using System;

namespace UziRubiksCube
	{
	/// <summary>
	/// Solution step result
	/// </summary>
	public class SolutionStep
		{
		/// <summary>
		/// Solution step code
		/// </summary>
		public StepCode StepCode;

		/// <summary>
		/// Text message associated with this step
		/// </summary>
		public string Message;

		/// <summary>
		/// Face number being focused on
		/// </summary>
		public int FaceNo;

		/// <summary>
		/// Up face color
		/// </summary>
		public int UpFaceColor;

		/// <summary>
		///  Front face color
		/// </summary>
		public int FrontFaceColor;

		/// <summary>
		/// Solution steps expressed in face color
		/// </summary>
		public int[] Steps;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="StepCode">Solution step code</param>
		/// <param name="Message">Text message</param>
		/// <param name="FaceNo">Face number being moved</param>
		/// <param name="UpFaceColor">Cube up face color</param>
		/// <param name="FrontFaceColor">Cube front face color</param>
		/// <param name="Steps">Solution steps</param>
		public SolutionStep
				(
				StepCode StepCode,
				string Message,
				int FaceNo,
				int UpFaceColor,
				int FrontFaceColor,
				int[] Steps
				)
			{
#if DEBUG
			if (UpFaceColor != Cube.WhiteFace && UpFaceColor != Cube.YellowFace)
				throw new ApplicationException("SolveStep up face must be white or yellow");
#endif

			this.StepCode = StepCode;
			this.Message = Message;
			this.FaceNo = FaceNo;
			this.UpFaceColor = UpFaceColor;
			this.FrontFaceColor = FrontFaceColor;
			this.Steps = Steps;
			return;
			}

		/// <summary>
		/// Constructor for cube is solved
		/// </summary>
		public SolutionStep()
			{
			StepCode = StepCode.CubeIsSolved;
			return;
			}
		}
	}
