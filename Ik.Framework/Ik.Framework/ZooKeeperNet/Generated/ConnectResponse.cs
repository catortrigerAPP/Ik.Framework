// File generated by hadoop record compiler. Do not edit.
/**
* Licensed to the Apache Software Foundation (ASF) under one
* or more contributor license agreements.  See the NOTICE file
* distributed with this work for additional information
* regarding copyright ownership.  The ASF licenses this file
* to you under the Apache License, Version 2.0 (the
* "License"); you may not use this file except in compliance
* with the License.  You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using Org.Apache.Jute;

namespace Org.Apache.Zookeeper.Proto
{
public class ConnectResponse : IRecord, IComparable 
{
  public ConnectResponse() {
  }
  public ConnectResponse(
  int protocolVersion
,
  int timeOut
,
  long sessionId
,
  byte[] passwd
) {
ProtocolVersion=protocolVersion;
TimeOut=timeOut;
SessionId=sessionId;
Passwd=passwd;
  }
  public int ProtocolVersion { get; set; } 
  public int TimeOut { get; set; } 
  public long SessionId { get; set; } 
  public byte[] Passwd { get; set; } 
  public void Serialize(IOutputArchive a_, String tag) {
    a_.StartRecord(this,tag);
    a_.WriteInt(ProtocolVersion,"protocolVersion");
    a_.WriteInt(TimeOut,"timeOut");
    a_.WriteLong(SessionId,"sessionId");
    a_.WriteBuffer(Passwd,"passwd");
    a_.EndRecord(this,tag);
  }
  public void Deserialize(IInputArchive a_, String tag) {
    a_.StartRecord(tag);
    ProtocolVersion=a_.ReadInt("protocolVersion");
    TimeOut=a_.ReadInt("timeOut");
    SessionId=a_.ReadLong("sessionId");
    Passwd=a_.ReadBuffer("passwd");
    a_.EndRecord(tag);
}
  public override String ToString() {
    try {
      System.IO.MemoryStream ms = new System.IO.MemoryStream();
      IkZooKeeperNet.IO.EndianBinaryWriter writer =
        new IkZooKeeperNet.IO.EndianBinaryWriter(IkZooKeeperNet.IO.EndianBitConverter.Big, ms, System.Text.Encoding.UTF8);
      BinaryOutputArchive a_ = 
        new BinaryOutputArchive(writer);
      a_.StartRecord(this,"");
    a_.WriteInt(ProtocolVersion,"protocolVersion");
    a_.WriteInt(TimeOut,"timeOut");
    a_.WriteLong(SessionId,"sessionId");
    a_.WriteBuffer(Passwd,"passwd");
      a_.EndRecord(this,"");
      ms.Position = 0;
      return System.Text.Encoding.UTF8.GetString(ms.ToArray());
    } catch (Exception ex) {
      Console.WriteLine(ex.StackTrace);
    }
    return "ERROR";
  }
  public void Write(IkZooKeeperNet.IO.EndianBinaryWriter writer) {
    BinaryOutputArchive archive = new BinaryOutputArchive(writer);
    Serialize(archive, "");
  }
  public void ReadFields(IkZooKeeperNet.IO.EndianBinaryReader reader) {
    BinaryInputArchive archive = new BinaryInputArchive(reader);
    Deserialize(archive, "");
  }
  public int CompareTo (object peer_) {
    if (!(peer_ is ConnectResponse)) {
      throw new InvalidOperationException("Comparing different types of records.");
    }
    ConnectResponse peer = (ConnectResponse) peer_;
    int ret = 0;
    ret = (ProtocolVersion == peer.ProtocolVersion)? 0 :((ProtocolVersion<peer.ProtocolVersion)?-1:1);
    if (ret != 0) return ret;
    ret = (TimeOut == peer.TimeOut)? 0 :((TimeOut<peer.TimeOut)?-1:1);
    if (ret != 0) return ret;
    ret = (SessionId == peer.SessionId)? 0 :((SessionId<peer.SessionId)?-1:1);
    if (ret != 0) return ret;
    ret = Passwd.CompareTo(peer.Passwd);
    if (ret != 0) return ret;
     return ret;
  }
  public override bool Equals(object peer_) {
    if (!(peer_ is ConnectResponse)) {
      return false;
    }
    if (peer_ == this) {
      return true;
    }
    bool ret = false;
    ConnectResponse peer = (ConnectResponse)peer_;
    ret = (ProtocolVersion==peer.ProtocolVersion);
    if (!ret) return ret;
    ret = (TimeOut==peer.TimeOut);
    if (!ret) return ret;
    ret = (SessionId==peer.SessionId);
    if (!ret) return ret;
    ret = Passwd.Equals(peer.Passwd);
    if (!ret) return ret;
     return ret;
  }
  public override int GetHashCode() {
    int result = 17;
    int ret;
    ret = (int)ProtocolVersion;
    result = 37*result + ret;
    ret = (int)TimeOut;
    result = 37*result + ret;
    ret = (int)SessionId;
    result = 37*result + ret;
    ret = Passwd.GetHashCode();
    result = 37*result + ret;
    return result;
  }
  public static string Signature() {
    return "LConnectResponse(iilB)";
  }
}
}
