CREATE TABLE [dbo].[MEMBER]
(
	[PID] [nvarchar](7) NOT NULL,
	[FName] [nvarchar](50) NOT NULL,
	[LName] [nvarchar](75) NOT NULL,
	[MI] [nvarchar](1) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](13) NULL,
	[PhotoPath] [nvarchar](300) NULL,
 CONSTRAINT [PK_MEMBER] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

CREATE TABLE [dbo].[ROLE]
(
	[RoleID] [nvarchar](15) NOT NULL,
	[RoleDescription] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ROLE] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

CREATE TABLE [dbo].[SECURITY]
(
	[PID] [nvarchar](7) NOT NULL,
	[UserID] [nvarchar](15) NOT NULL,
	[Password] [nvarchar](8) NOT NULL,
	[SecRole] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

ALTER TABLE [dbo].[SECURITY]  WITH CHECK ADD  CONSTRAINT [FK_USER_MEMBER] FOREIGN KEY([PID])
REFERENCES [dbo].[MEMBER] ([PID])
ON UPDATE CASCADE
;

ALTER TABLE [dbo].[SECURITY] CHECK CONSTRAINT [FK_USER_MEMBER]
;

CREATE TABLE [dbo].[AUDIT]
(
	[ukid] [int] IDENTITY(1,1) NOT NULL,
	[PID] [nvarchar](7) NOT NULL,
	[ACCESSTIMESTAMP] [smalldatetime] NOT NULL,
	[SUCCESS] [bit] NOT NULL,
 CONSTRAINT [PK_AUDIT] PRIMARY KEY CLUSTERED 
(
	[ukid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

ALTER TABLE [dbo].[AUDIT]  WITH CHECK ADD  CONSTRAINT [FK_AUDIT_MEMBER] FOREIGN KEY([PID])
REFERENCES [dbo].[MEMBER] ([PID])
ON UPDATE CASCADE
;

ALTER TABLE [dbo].[AUDIT] CHECK CONSTRAINT [FK_AUDIT_MEMBER]
;

CREATE TABLE [dbo].[COURSE]
(
	[CourseID] [nvarchar](10) NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_COURSE] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

CREATE TABLE [dbo].[SEMESTER]
(
	[SemesterID] [nvarchar](4) NOT NULL,
	[SemesterDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_SEMSTER] PRIMARY KEY CLUSTERED 
(
	[SemesterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

CREATE TABLE [dbo].[MEMBER_ROLE]
(
	[ukid] [int] IDENTITY(1,1) NOT NULL,
	[PID] [nvarchar](7) NOT NULL,
	[RoleID] [nvarchar](15) NOT NULL,
	[SemesterID] [nvarchar](4) NOT NULL,
 CONSTRAINT [PK_MEMBERROLE] PRIMARY KEY CLUSTERED 
(
	[ukid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

ALTER TABLE [dbo].[MEMBER_ROLE]  WITH CHECK ADD  CONSTRAINT [FK_MEMBER_ROLE_MEMBER] FOREIGN KEY([PID])
REFERENCES [dbo].[MEMBER] ([PID])
ON UPDATE CASCADE
;

ALTER TABLE [dbo].[MEMBER_ROLE] CHECK CONSTRAINT [FK_MEMBER_ROLE_MEMBER]
;

ALTER TABLE [dbo].[MEMBER_ROLE]  WITH CHECK ADD  CONSTRAINT [FK_MEMBER_ROLE_ROLE] FOREIGN KEY([RoleID])
REFERENCES [dbo].[ROLE] ([RoleID])
ON UPDATE CASCADE
;

ALTER TABLE [dbo].[MEMBER_ROLE] CHECK CONSTRAINT [FK_MEMBER_ROLE_ROLE]
;

ALTER TABLE [dbo].[MEMBER_ROLE]  WITH CHECK ADD  CONSTRAINT [FK_MEMBER_ROLE_SEMESTER] FOREIGN KEY([SemesterID])
REFERENCES [dbo].[SEMESTER] ([SemesterID])
ON UPDATE CASCADE
;

ALTER TABLE [dbo].[MEMBER_ROLE] CHECK CONSTRAINT [FK_MEMBER_ROLE_SEMESTER]
;


CREATE TABLE [dbo].[EVENT_TYPE]
(
	[EventTypeID] [nvarchar](15) NOT NULL,
	[EventTypeDescription] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_EVENT_TYPE] PRIMARY KEY CLUSTERED 
(
	[EventTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;


CREATE TABLE [dbo].[EVENT]
(
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[EventDescription] [nvarchar](500) NOT NULL,
	[EventTypeID] [nvarchar](15) NOT NULL,
	[SemesterID] [nvarchar](4) NOT NULL,
	[StartDate] [smalldatetime] NOT NULL,
	[EndDate] [smalldatetime] NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EVENT] PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

ALTER TABLE [dbo].[EVENT]  WITH CHECK ADD  CONSTRAINT [FK_EVENT_EVENT_TYPE] FOREIGN KEY([EventTypeID])
REFERENCES [dbo].[EVENT_TYPE] ([EventTypeID])
ON UPDATE CASCADE
;

ALTER TABLE [dbo].[EVENT] CHECK CONSTRAINT [FK_EVENT_EVENT_TYPE]
;

ALTER TABLE [dbo].[EVENT]  WITH CHECK ADD  CONSTRAINT [FK_EVENT_SEMESTER] FOREIGN KEY([SemesterID])
REFERENCES [dbo].[SEMESTER] ([SemesterID])
ON UPDATE CASCADE
;

ALTER TABLE [dbo].[EVENT] CHECK CONSTRAINT [FK_EVENT_SEMESTER]
;

CREATE TABLE [dbo].[EVENT_RSVP]
(
	[ukid] [int] IDENTITY(1,1) NOT NULL,
	[EventID] [int] NOT NULL,
	[FName] [nvarchar](50) NOT NULL,
	[LName] [nvarchar](75) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EVENT_RSVP] PRIMARY KEY CLUSTERED 
(
	[ukid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

ALTER TABLE [dbo].[EVENT_RSVP]  WITH CHECK ADD  CONSTRAINT [FK_EVENT_RSVP_EVENT] FOREIGN KEY([EventID])
REFERENCES [dbo].[EVENT] ([EventID])
;

ALTER TABLE [dbo].[EVENT_RSVP] CHECK CONSTRAINT [FK_EVENT_RSVP_EVENT]
;

CREATE TABLE [dbo].[TUTOR_COURSE]
(
	[ukid] [int] IDENTITY(1,1) NOT NULL,
	[PID] [nvarchar](7) NOT NULL,
	[CourseID] [nvarchar](10) NOT NULL,
	[SemesterID] [nvarchar](4) NOT NULL,
 CONSTRAINT [PK_TUTOR_COURSE] PRIMARY KEY CLUSTERED 
(
	[ukid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

ALTER TABLE [dbo].[TUTOR_COURSE]  WITH CHECK ADD  CONSTRAINT [FK_TUTOR_COURSE_COURSE] FOREIGN KEY([CourseID])
REFERENCES [dbo].[COURSE] ([CourseID])
ON UPDATE CASCADE
;

ALTER TABLE [dbo].[TUTOR_COURSE] CHECK CONSTRAINT [FK_TUTOR_COURSE_COURSE]
;

ALTER TABLE [dbo].[TUTOR_COURSE]  WITH CHECK ADD  CONSTRAINT [FK_TUTOR_COURSE_MEMBER] FOREIGN KEY([PID])
REFERENCES [dbo].[MEMBER] ([PID])
;

ALTER TABLE [dbo].[TUTOR_COURSE] CHECK CONSTRAINT [FK_TUTOR_COURSE_MEMBER]
;

