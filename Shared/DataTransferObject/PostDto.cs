﻿using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject;

//public record PostDto(int PostId, string? PostContent, ICollection<PostPhoto> PostPhotos, ICollection<Like> Likes, ICollection<Comment> Comments, DateTime? UpdateDate, DateTime? CreatedDate);
public record PostDto(
    int PostId,
    string? PostContent,
    double? x,
    double? y,
    DateTime? UpdateDate,
    DateTime? CreatedDate
);
