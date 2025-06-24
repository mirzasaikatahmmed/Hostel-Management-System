using Hostel_Management_System.Model;
using System;
using System.Collections.Generic;

namespace Hostel_Management_System.Controller
{
    public class RoomAssignmentController
    {
        public List<RoomAssignmentModel> GetAllRoomAssignments()
        {
            return RoomAssignmentModel.GetAllRoomAssignments();
        }

        public RoomAssignmentModel GetRoomAssignmentById(int id)
        {
            return RoomAssignmentModel.GetRoomAssignmentById(id);
        }

        public bool AssignRoomToStudent(RoomAssignmentModel assignment)
        {
            return RoomAssignmentModel.AssignRoomToStudent(assignment);
        }

        public bool UpdateRoomAssignment(RoomAssignmentModel assignment)
        {
            return RoomAssignmentModel.UpdateRoomAssignment(assignment);
        }

        public bool DeleteRoomAssignment(int assignmentID, int studentID, int roomID)
        {
            return RoomAssignmentModel.DeleteRoomAssignment(assignmentID, studentID, roomID);
        }
    }
}