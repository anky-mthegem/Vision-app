using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using Cognex.Cnx.Imaging;
using Cognex.InSight.Layout;

namespace Cognex.InSight.Internal;

public interface ICvsImageBuffer : IDisposable
{
	CvsFont DefaultFont { get; set; }

	float FontScale { get; set; }

	Size Size { get; }

	CnxPixelFormat PixelFormat { get; }

	CvsClippingRegion Clip { get; set; }

	CvsDrawMode DrawMode { get; set; }

	Matrix Transform { get; set; }

	bool PrintBuffer { get; set; }

	Color GetPixel(int x, int y);

	void SetPixel(int x, int y, Color color);

	void ReadPixels(Array pixels, int startIndex, CnxPixelFormat rawPixelFormat, Point location, int pixelCount);

	void WritePixels(Array pixels, int startIndex, CnxPixelFormat rawPixelFormat, Point location, int pixelCount);

	void ReadPixels(IntPtr pixels, CnxPixelFormat rawPixelFormat, Point location, int pixelCount);

	void WritePixels(IntPtr pixels, CnxPixelFormat rawPixelFormat, Point location, int pixelCount);

	void StreamPixels(Stream stream, bool readFromStream, CnxPixelFormat rawPixelFormat, Rectangle region);

	object GetNativeStorage();

	void ReleaseNativeStorage(object storage);

	IntPtr GetMemoryPtr(bool write, out int stride, out CnxPixelFormat nativePixelFormat);

	void ReleaseMemoryPtr();

	Array GetPixels(int dimensions);

	Graphics GetGraphics();

	void ReleaseGraphics();

	void ReplacePixels(Rectangle rect, Color colorMatch, Color colorReplace);

	void ReplaceGrayValues(Rectangle rect, Color[] colors);

	Bitmap ToBitmap();

	Bitmap CreateBitmap();

	void Save(string fileName);

	void CopyTo(IntPtr hdc, Rectangle destination, Point source);

	void WriteBitmap(ref Stream stm, CnxPixelFormat format);

	ICvsImageBuffer Transpose(CvsImageOrientation orientation);

	void DrawLine(Color color, int x1, int y1, int x2, int y2);

	void DrawLine(Color color, int x1, int y1, int x2, int y2, int lineWidth);

	void DrawLine(Color color, int x1, int y1, int x2, int y2, int lineWidth, CvsDashStyles dashStyle);

	void DrawLines(Color color, Point[] points, int lineWidth);

	void DrawLines(Color color, Point[] points, int lineWidth, CvsDashStyles dashStyle);

	void DrawArc(Color color, float cx, float cy, float radius, float startAngle, float sweepAngle);

	void DrawArc(Color color, float cx, float cy, float radius, float startAngle, float sweepAngle, int lineWidth);

	void DrawArc(Color color, float cx, float cy, float radius, float startAngle, float sweepAngle, int lineWidth, CvsDashStyles dashStyle);

	void DrawRectangle(Color color, Rectangle rect);

	void DrawRectangle(Color color, int x, int y, int width, int height);

	void DrawRectangle(Color color, int x, int y, int width, int height, int lineWidth);

	void DrawRectangle(Color color, int x, int y, int width, int height, int lineWidth, CvsDashStyles dashStyle);

	void Draw3DRectangle(Rectangle rect);

	void Draw3DRectangle(Color fillColor, Rectangle rect);

	void Draw3DRectangle(Color fillColor, Color lightColor, Color lightLightColor, Color darkColor, Color darkDarkColor, Rectangle rect);

	void FillRectangle(Color color, Rectangle rect);

	void DrawEllipse(Color color, float x, float y, float width, float height);

	void DrawEllipse(Color color, float x, float y, float width, float height, int lineWidth);

	void FillEllipse(Color color, float x, float y, float width, float height);

	SizeF MeasureString(string s);

	SizeF MeasureString(string s, CvsFont font);

	SizeF MeasureString(string s, CvsFont font, bool symbols);

	SizeF MeasureInSightString(string s, CvsFont font);

	void DrawString(string s, Color foreColor, int x, int y);

	void DrawString(string s, Color foreColor, Rectangle rect);

	void DrawString(string s, Color foreColor, Color backColor, Rectangle rect);

	void DrawString(string s, Color foreColor, Color backColor, Rectangle rect, CvsTextFormat format);

	void DrawString(string s, CvsFont font, Color foreColor, Rectangle rect);

	void DrawString(string s, CvsFont font, Color foreColor, int x, int y);

	void DrawString(string s, CvsFont font, Color foreColor, Color backColor, Rectangle rect, CvsTextFormat format);

	void DrawImage(ICvsImageBuffer image, Rectangle destRect, Rectangle sourceRect);

	void DrawImage(CvsImage image, Rectangle destRect, Rectangle sourceRect);

	void DrawImageTransparent(ICvsImageBuffer image, Rectangle destRect, Rectangle sourceRect, Color transparencyKey);

	void DrawArrow(Color color, float x, float y, double angle, int lineWidth, bool large);

	void DrawPolygon(Color color, Point[] points, int lineWidth, CvsDashStyles dashStyle);

	void DrawPolygon(Color color, Point[] points, int lineWidth);

	void DrawPolygon(Color color, Point[] points);
}
