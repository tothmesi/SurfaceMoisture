using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurfaceMoistureLib;
using SurfaceMoistureLib.Exceptions;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MaxValueMismatchedTest()
        {
            try
            {
                var palette = new Palette();

                int[] scaleValues = { 40, 70, 100, 140 };
                int max = 160;
                palette.SetPalette(scaleValues, max);

                var expectedIntervals = new[]
                {
                    new Interval {From = 0, To = 40, Type = CategoryType.Dry},
                    new Interval {From = 41, To = 70, Type = CategoryType.SoftWet},
                    new Interval {From = 71, To = 100, Type = CategoryType.Wet},
                    new Interval {From = 101, To = 140, Type = CategoryType.ExremelyWet},
                };

                Assert.IsNotNull(palette.Intervals);
                Assert.AreEqual(scaleValues.Length, palette.Intervals.Length);

                for (int i = 0; i < expectedIntervals.Length; i++)
                {
                    Assert.AreEqual(expectedIntervals[i].From, palette.Intervals[i].From);
                    Assert.AreEqual(expectedIntervals[i].To, palette.Intervals[i].To);
                    Assert.AreEqual(expectedIntervals[i].Type, palette.Intervals[i].Type);
                }

                Assert.AreEqual(max, palette.Intervals[palette.Intervals.Length - 1].To);
            }
            catch (ScaleValueMismatchedToMaxException ex)
            {
                //ha ilyet kaptunk, akkor örülünk :)
                Debug.WriteLine("Az elvárt hibát kaptuk: {0}", ex);
            }
            catch (Exception)
            {
                //ha egyéb hibát kapunk, akkor az tényleg hiba
                throw;
            }
        }

        [TestMethod]
        public void SetPaletteTest()
        {
            var palette = new Palette();

            int[] scaleValues = { 40, 70, 100, 140 };
            int max = 140;
            palette.SetPalette(scaleValues, max);

            var expectedIntervals = new[]
                {
                    new Interval {From = 0, To = 40, Type = CategoryType.Dry},
                    new Interval {From = 41, To = 70, Type = CategoryType.SoftWet},
                    new Interval {From = 71, To = 100, Type = CategoryType.Wet},
                    new Interval {From = 101, To = 140, Type = CategoryType.ExremelyWet},
                };

            Assert.IsNotNull(palette.Intervals);
            Assert.AreEqual(scaleValues.Length, palette.Intervals.Length);

            for (int i = 0; i < expectedIntervals.Length; i++)
            {
                Assert.AreEqual(expectedIntervals[i].From, palette.Intervals[i].From);
                Assert.AreEqual(expectedIntervals[i].To, palette.Intervals[i].To);
                Assert.AreEqual(expectedIntervals[i].Type, palette.Intervals[i].Type);
            }

            Assert.AreEqual(max, palette.Intervals[palette.Intervals.Length - 1].To);
        }
    }
}
