using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;

namespace Cognex.Tako;

public interface Scene
{
	public enum DragEvent
	{
		Begin,
		Move,
		End,
		Cancel
	}

	public class DragEventArgs : EventArgs
	{
		public int Id;

		public DragEvent Event;

		public float[] Point;

		public bool Handled;

		public DragEventArgs(int id, int ev, float[] p)
		{
			Id = id;
			Event = (DragEvent)ev;
			Point = p;
			Handled = false;
		}
	}

	bool WireframeAsEdges
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get;
		[param: MarshalAs(UnmanagedType.U1)]
		set;
	}

	Color GridColor { get; set; }

	GridUnits GridUnits { get; set; }

	bool ShowGrid
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get;
		[param: MarshalAs(UnmanagedType.U1)]
		set;
	}

	float CreatorOpacity { get; set; }

	Color CreatorColor { get; set; }

	int SelectionPixelTolerance { get; set; }

	bool DisableLambertOnAllowedModels
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get;
		[param: MarshalAs(UnmanagedType.U1)]
		set;
	}

	string ColorbarLabel { get; set; }

	Color ColorbarTicksColor { get; set; }

	int ColorbarDecimalPlaces { get; set; }

	int ColorbarSubdivisions { get; set; }

	bool ColorbarVisible
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get;
		[param: MarshalAs(UnmanagedType.U1)]
		set;
	}

	int SceneCuttingPlane { get; set; }

	bool AxesVisible
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get;
		[param: MarshalAs(UnmanagedType.U1)]
		set;
	}

	LightType LightType { get; set; }

	CameraControlModeType CameraControlMode { get; set; }

	CameraModeType CameraMode { get; set; }

	Color SelectionBoxColor { get; set; }

	Vector3D CameraUpDirection { get; }

	Point3D CameraPosition { get; }

	Point3D CameraTarget { get; }

	Color BackColor { get; set; }

	DisplayMode Mode { get; set; }

	int Selected { get; set; }

	float HeightColorWeight { get; set; }

	[SpecialName]
	event EventHandler<DragEventArgs> OnDrag;

	[SpecialName]
	event EventHandler<CreatorEventArgs> OnCreated;

	[SpecialName]
	event EventHandler<MousePosChangedEventArgs> MousePosChanged;

	[SpecialName]
	event EventHandler<SelectionChangedEventArgs> SelectionChanged;

	int AddNode(Node node);

	void SetInteractiveModel(int id, [MarshalAs(UnmanagedType.U1)] bool enable_interactive, int handles_to_enable);

	void SetInteractiveModel(int id, [MarshalAs(UnmanagedType.U1)] bool enable_interactive);

	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInteractiveModel(int id);

	int GetEnabledHandlesForModel(int id);

	void DeleteNode(int id);

	int[] GetNodeIds();

	void Clear();

	void FitView();

	void ResetView(Vector3D dir, Vector3D up);

	void ResetView(Vector3D dir);

	void ResetView();

	void SetView(Point3D eye, Point3D target, Vector3D up);

	void SaveImage(string filename, int width, int height);

	void SaveImage(string filename);

	Node GetNode(int id);

	string GetRenderer();

	BitmapSource ReadPixels(int width, int height);

	BitmapSource ReadPixels();

	void SetHeightColor(DirectionalHeightColor height_color, float height_color_weight);

	void SetHeightColor(DirectionalHeightColor height_color);

	void ClearHeightColor();

	DirectionalHeightColor GetHeightColor();

	void SetMouseTracking(TrackingTarget target);

	TrackingTarget GetMouseTracking();

	Transform GetProjectionMatrix();

	CameraSettings GetCameraSettings();

	void SetCameraSettings(CameraSettings settings);

	void SetCreatorEnabled(CreatorMode mode);

	void SetCreatorDisabled();

	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCreatorIsEnabled();
}
