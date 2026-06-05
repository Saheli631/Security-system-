# Crew Security Approval & Entry Pass System

## Overview

A full-stack ASP.NET Core MVC web application developed during internship work for managing contractor crew approvals, document verification, and secure entry pass generation for industrial access control.

The system supports:
- Multi-level admin approval workflow
- Crew registration & document upload
- Status tracking
- Entry pass generation
- PDF export
- Role-based visibility

Built using:
- ASP.NET Core MVC
- SQL Server
- Entity Framework Core
- Bootstrap
- JavaScript
- HTML/CSS

---

# Features

## Crew Management
- Add new crew members
- Upload profile photo
- Edit crew details
- View crew profiles
- Country & section mapping
- Contractor association

---

## Document Management

Crew members can upload:
- CV / Work Experience
- H2S Certification
- BOSIET / FOET Certificate
- Passport
- Medical Fitness Certificate
- MOHA Clearance
- Visa

### Features
- Issue date tracking
- Expiry date tracking
- View uploaded documents
- Auto status updates

---

# Multi-Level Approval System

## Level-Based Workflow

Supports:
- Level 1 Admin
- Level 2 Admin

### Features
- Approve documents
- Reject documents
- Send for clarification
- Add remarks
- Controlled access by approval level

---

# Admin Dashboard

Includes:
- Pending Crew Count
- Approved Crew Count
- Rejected Crew Count
- Clarification Cases
- Issued Pass Count

### Additional Features
- View all crew
- Review uploaded documents
- Update approval statuses
- Issue entry passes

---

# Entry Pass Generation

## Smart Pass System

Pass generation available only for:
- Fully approved crew members

### Features
- Auto-generated pass number
- Crew photo integration
- Contractor information
- Section & country details
- Admin-defined expiry date popup
- Foldable front/back pass design
- Printable layout
- PDF download support

---

# PDF Export

Implemented using:
- `html2canvas`
- `jsPDF`

### Features
- High-quality downloadable PDF
- Front & back pass in same page
- Symmetrical fold layout
- Professional print-ready format

---

# Tech Stack

## Frontend
- HTML5
- CSS3
- Bootstrap 5
- JavaScript

## Backend
- ASP.NET Core MVC
- C#

## Database
- SQL Server
- Entity Framework Core

## Additional Libraries
- html2canvas
- jsPDF

---

# Database Tables

## Master Tables
- Countries
- Contractors
- Sections
- Blocks
- ApprovalLevels
- Statuses
- DocumentCategories

## Transaction Tables
- CrewMembers
- CrewMemberDocuments
- CrewMemberDocumentApprovals

---

# Security Features

- Session-based admin authentication
- Role-based approval visibility
- Controlled pass issuance
- Validation checks before approval
- Access restriction by approval level

---

# Project Highlights

- Real-world industrial workflow implementation
- Enterprise-style approval architecture
- Dynamic PDF generation
- Multi-stage verification system
- Responsive UI design
- JSON-based pass record storage
- Scalable MVC architecture

---

# Future Enhancements

- Email notifications
- OTP verification
- QR code on entry pass
- Admin analytics dashboard
- Cloud storage integration
- Audit logs
- Digital signatures

---

