﻿#nullable disable

namespace LearnCSharpInSematec.Dtos;


//DTO
public sealed class AddStudent
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string NationalCode { get; set; }
}