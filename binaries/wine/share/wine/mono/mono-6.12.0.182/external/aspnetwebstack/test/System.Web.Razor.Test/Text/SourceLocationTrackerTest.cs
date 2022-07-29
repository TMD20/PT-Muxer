﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Razor.Text;
using Xunit;

namespace System.Web.Razor.Test.Text
{
    public class SourceLocationTrackerTest
    {
        private static readonly SourceLocation TestStartLocation = new SourceLocation(10, 42, 45);

        [Fact]
        public void ConstructorSetsCurrentLocationToZero()
        {
            Assert.Equal(SourceLocation.Zero, new SourceLocationTracker().CurrentLocation);
        }

        [Fact]
        public void ConstructorWithSourceLocationSetsCurrentLocationToSpecifiedValue()
        {
            SourceLocation loc = new SourceLocation(10, 42, 4);
            Assert.Equal(loc, new SourceLocationTracker(loc).CurrentLocation);
        }

        [Fact]
        public void UpdateLocationAdvancesAbsoluteIndexOnNonNewlineCharacter()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('f', 'o');

            // Assert
            Assert.Equal(11, tracker.CurrentLocation.AbsoluteIndex);
        }

        [Fact]
        public void UpdateLocationAdvancesCharacterIndexOnNonNewlineCharacter()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('f', 'o');

            // Assert
            Assert.Equal(46, tracker.CurrentLocation.CharacterIndex);
        }

        [Fact]
        public void UpdateLocationDoesNotAdvanceLineIndexOnNonNewlineCharacter()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('f', 'o');

            // Assert
            Assert.Equal(42, tracker.CurrentLocation.LineIndex);
        }

        [Fact]
        public void UpdateLocationAdvancesLineIndexOnSlashN()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('\n', 'o');

            // Assert
            Assert.Equal(43, tracker.CurrentLocation.LineIndex);
        }

        [Fact]
        public void UpdateLocationAdvancesAbsoluteIndexOnSlashN()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('\n', 'o');

            // Assert
            Assert.Equal(11, tracker.CurrentLocation.AbsoluteIndex);
        }

        [Fact]
        public void UpdateLocationResetsCharacterIndexOnSlashN()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('\n', 'o');

            // Assert
            Assert.Equal(0, tracker.CurrentLocation.CharacterIndex);
        }

        [Fact]
        public void UpdateLocationAdvancesLineIndexOnSlashRFollowedByNonNewlineCharacter()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('\r', 'o');

            // Assert
            Assert.Equal(43, tracker.CurrentLocation.LineIndex);
        }

        [Fact]
        public void UpdateLocationAdvancesAbsoluteIndexOnSlashRFollowedByNonNewlineCharacter()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('\r', 'o');

            // Assert
            Assert.Equal(11, tracker.CurrentLocation.AbsoluteIndex);
        }

        [Fact]
        public void UpdateLocationResetsCharacterIndexOnSlashRFollowedByNonNewlineCharacter()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('\r', 'o');

            // Assert
            Assert.Equal(0, tracker.CurrentLocation.CharacterIndex);
        }

        [Fact]
        public void UpdateLocationDoesNotAdvanceLineIndexOnSlashRFollowedBySlashN()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('\r', '\n');

            // Assert
            Assert.Equal(42, tracker.CurrentLocation.LineIndex);
        }

        [Fact]
        public void UpdateLocationAdvancesAbsoluteIndexOnSlashRFollowedBySlashN()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('\r', '\n');

            // Assert
            Assert.Equal(11, tracker.CurrentLocation.AbsoluteIndex);
        }

        [Fact]
        public void UpdateLocationAdvancesCharacterIndexOnSlashRFollowedBySlashN()
        {
            // Arrange
            SourceLocationTracker tracker = new SourceLocationTracker(TestStartLocation);

            // Act
            tracker.UpdateLocation('\r', '\n');

            // Assert
            Assert.Equal(46, tracker.CurrentLocation.CharacterIndex);
        }
    }
}
