Rocket elevator REST Api
# Rocket Elevator
`test `
GET
`https://rocketelevatorapi.azurewebsites.net/api/columns/5`

this command is how u get the columns you try too change


PUT
api/columns/5/Active
<https://rocketelevatorapi.azurewebsites.net/api/columns/5/Active

{
  "id": 5,
  "columnType": "Hybrid",
  "nbOfFloorsServed": 1,
  "status": "Intervention",
  "info": "Reprehenderit cum autem.",
  "notes": "Nemo ea et.",
  "created_at": "2021-07-05T18:05:26",
  "updated_at": "2021-07-05T18:05:26",
  "battery_id": 2
}
PUT
api/columns/5/Inactive
<https://rocketelevatorapi.azurewebsites.net/api/columns/5/Inactive

{
  "id": 5,
  "columnType": "Hybrid",
  "nbOfFloorsServed": 1,
  "status": "Intervention",
  "info": "Reprehenderit cum autem.",
  "notes": "Nemo ea et.",
  "created_at": "2021-07-05T18:05:26",
  "updated_at": "2021-07-05T18:05:26",
  "battery_id": 2
}
PUT
api/columns/5/Intervention
<https://rocketelevatorapi.azurewebsites.net/api/columns/5/Intervention


{
  "id": 5,
  "columnType": "Hybrid",
  "nbOfFloorsServed": 1,
  "status": "Intervention",
  "info": "Reprehenderit cum autem.",
  "notes": "Nemo ea et.",
  "created_at": "2021-07-05T18:05:26",
  "updated_at": "2021-07-05T18:05:26",
  "battery_id": 2
}
GET
api/elevators/5
<https://rocketelevatorapi.azurewebsites.net/api/elevators/5

this command is how u get the elevator u try too change

api/elevators/5/Active
<https://rocketelevatorapi.azurewebsites.net/api/elevators/5/Active

{
  "id": 5,
  "serialNumber": "D66I0N1FM00815614",
  "model": "Regal",
  "elevatorType": "Hybrid",
  "status": "Active",
  "dateOfCommissioning": "2021-10-12T00:00:00",
  "dateOfLastInspection": "2021-09-08T00:00:00",
  "certificateOfInspection": "Rusty Fossat",
  "info": "Tempore corrupti vel.",
  "notes": "Quam nam rerum.",
  "created_at": "2021-07-08T02:19:13",
  "updated_at": "2021-07-08T02:19:13",
  "column_id": 2
}
PUT
api/elevators/5/Inactive
<https://rocketelevatorapi.azurewebsites.net/api/elevators/5/Inactive

{
  "id": 5,
  "serialNumber": "D66I0N1FM00815614",
  "model": "Regal",
  "elevatorType": "Hybrid",
  "status": "Inactive",
  "dateOfCommissioning": "2021-10-12T00:00:00",
  "dateOfLastInspection": "2021-09-08T00:00:00",
  "certificateOfInspection": "Rusty Fossat",
  "info": "Tempore corrupti vel.",
  "notes": "Quam nam rerum.",
  "created_at": "2021-07-08T02:19:13",
  "updated_at": "2021-07-08T02:19:13",
  "column_id": 2
}
PUT
api/elevators/5/Intervention
<https://rocketelevatorapi.azurewebsites.net/api/elevators/5/Intervention

{
  "id": 5,
  "serialNumber": "D66I0N1FM00815614",
  "model": "Regal",
  "elevatorType": "Hybrid",
  "status": "Active",
  "dateOfCommissioning": "2021-10-12T00:00:00",
  "dateOfLastInspection": "2021-09-08T00:00:00",
  "certificateOfInspection": "Rusty Fossat",
  "info": "Tempore corrupti vel.",
  "notes": "Quam nam rerum.",
  "created_at": "2021-07-08T02:19:13",
  "updated_at": "2021-07-08T02:19:13",
  "column_id": 2
}
GET
api/batteries/5
<https://rocketelevatorapi.azurewebsites.net/api/batteries/5

this command is how u get the batteries you try too change

api/batteries/5/Active
<https://rocketelevatorapi.azurewebsites.net/api/batteries/5/Active

{
  "id": 5,
  "bType": "Corporate",
  "status": "Inactive",
  "dateOfCommissioning": "2021-12-13T00:00:00",
  "dateOfLastInspection": "2021-09-28T00:00:00",
  "info": "Accusamus nesciunt praesentium.",
  "notes": "Et vitae laboriosam.",
  "created_at": "2021-07-08T02:19:14",
  "updated_at": "2021-07-08T02:19:14",
  "building_id": 5,
  "employee_id": 4
}

api/batteries/5/Inactive
<https://rocketelevatorapi.azurewebsites.net/api/batteries/5/Inactive

{
  "id": 5,
  "bType": "Corporate",
  "status": "Inactive",
  "dateOfCommissioning": "2021-12-13T00:00:00",
  "dateOfLastInspection": "2021-09-28T00:00:00",
  "info": "Accusamus nesciunt praesentium.",
  "notes": "Et vitae laboriosam.",
  "created_at": "2021-07-08T02:19:14",
  "updated_at": "2021-07-08T02:19:14",
  "building_id": 5,
  "employee_id": 4
}
PUT
api/batteries/5/Intervention
<https://rocketelevatorapi.azurewebsites.net/api/batteries/5/Intervention

{
  "id": 5,
  "bType": "Corporate",
  "status": "Inactive",
  "dateOfCommissioning": "2021-12-13T00:00:00",
  "dateOfLastInspection": "2021-09-28T00:00:00",
  "info": "Accusamus nesciunt praesentium.",
  "notes": "Et vitae laboriosam.",
  "created_at": "2021-07-08T02:19:14",
  "updated_at": "2021-07-08T02:19:14",
  "building_id": 5,
  "employee_id": 4
}

api/elevators/notactive
<https://rocketelevatorapi.azurewebsites.net/api/elevators/notactive

this command is how u get the elevator that are not active

api/building/Intervention
<https://rocketelevatorapi.azurewebsites.net/api/building/Intervention

this command is how u get the building that need intervention

api/lead
<https://rocketelevatorapi.azurewebsites.net/api/lead

this command is how u get a list of lead
